using Final_Project.BussinessLogic.Interfaces;
using Final_Project.BussinessLogic.SectionManagerct;
using Final_Project.BussinessLogic.Services;
using Final_Project.DataAccess.Repositories;
using Final_Project.Models;
using System;
using Final_Project.DataAccess;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project.Forms
{
    public partial class PurchaseOrderForm : Form
    {
        private IProductService _productService;
        private IImportOrderService importOrderService;
        private ImportOrder _importOrder;
        private BindingSource _bindingSource;
        private Product _product;
        public PurchaseOrderForm()
        {
            InitializeComponent();


            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                LoadService();
            }

            PurchaseOrderForm_Load(this, EventArgs.Empty);
        }

        private void PurchaseOrderForm_Load(object sender, EventArgs e)
        {
            // Turn off autocolumn
            product_datagridview.AutoGenerateColumns = false;

            // Xóa tất cả cột hiện có
            product_datagridview.Columns.Clear();

            // Add columns to datagridview
            product_datagridview.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "ProductId",
                HeaderText = "Product ID",
                DataPropertyName = "ProductId",
                Width = 100
            });

            product_datagridview.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "ProductName",
                HeaderText = "Product Name",
                DataPropertyName = "ProductName",
                Width = 200
            });

            product_datagridview.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Quantity",
                HeaderText = "Quantity",
                DataPropertyName = "Quantity",
                Width = 100
            });

            product_datagridview.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Price",
                HeaderText = "Price",
                DataPropertyName = "Price",
                Width = 100
            });

            product_datagridview.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "TotalPrice",
                HeaderText = "Total Price",
                DataPropertyName = "TotalPrice",
                Width = 100
            });


            // assign data source
            _bindingSource.DataSource = _importOrder.ImportOrderDetail;
            product_datagridview.DataSource = _bindingSource;

            // create date
            create_date_label.Text = DateTime.Now.ToString("dd/MM/yyyy");

            // event when user edit quantity
            product_datagridview.CellValueChanged += Product_datagridview_CellValueChanged;

        }

        private void Product_datagridview_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == product_datagridview.Columns["Quantity"].Index)
            {
                int quantity;
                if (int.TryParse(product_datagridview.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString(), out quantity) && quantity <= 0)
                {
                    MessageBox.Show("Quantity must be greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    product_datagridview.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 1;
                    _importOrder.ImportOrderDetail[e.RowIndex].Quantity = 1;
                }
                UpdateOrderSummary();
            }
        }
        // update total price of import detail
        private void UpdateOrderSummary()
        {
            _importOrder.UpdateTotal();
            totalitem_label.Text = _importOrder.TotalQuantity.ToString();
            totalamount_label.Text = _importOrder.TotalPrice.ToString("N0") + " đ";
        }

        // add button to add product
        private void add_button_Click(object sender, EventArgs e)
        {
            string name = name_textbox.Text;

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter product name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // List product search by name
            List<Product> products = _productService.SearchProductByName(name);

            if (products.Count == 0)
            {
                MessageBox.Show("Product not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(products.Count > 0)
            {
                AddProductToOrder(products[0]);s
            }

            name_textbox.Clear();
            name_textbox.Focus();
        }

        private void AddProductToOrder(Product product)
        {
            // Kiểm tra xem sản phẩm đã có trong đơn chưa
            ImportOrderDetail existingDetail = _importOrder.ImportOrderDetail.Find(d => d.ProductId == product.ProductId);

            if (existingDetail != null)
            {
                // Nếu đã có, tăng số lượng
                existingDetail.Quantity += 1;
            }
            else
            {
                // Nếu chưa có, thêm mới
                ImportOrderDetail detail = new ImportOrderDetail
                {
                    ProductId = product.ProductId,
                    Product = product,
                    Quantity = 1,
                    UnitPrice = product.Price
                };

                _importOrder.ImportOrderDetail.Add(detail);

            }

            // Cập nhật dữ liệu
            _bindingSource.ResetBindings(false);
            UpdateOrderSummary();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            if (product_datagridview.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please choose a product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int rowIndex = product_datagridview.SelectedRows[0].Index;
            _importOrder.ImportOrderDetail.RemoveAt(rowIndex);
            _bindingSource.ResetBindings(false);
            UpdateOrderSummary();
        }

        // save button
        private void save_button_Click(object sender, EventArgs e)
        {
            // check if supplier name is empty
            if (string.IsNullOrEmpty(supplier_textbox.Text))
            {
                MessageBox.Show("Please enter supplier name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // check if any product in order
            if (_importOrder.ImportOrderDetail.Count == 0)
            {
                MessageBox.Show("Please add product to order", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Update infor
                _importOrder.CreatedAt = DateTime.Parse(create_date_label.Text);
                _importOrder.AdminId = SectionManager.Instance.CurrentAdmin.AdminId;
                _importOrder.SupplierName = supplier_textbox.Text.Trim();

                int orderId = importOrderService.CreateImportOrder(_importOrder);

                if (orderId > 0)
                {
                    MessageBox.Show("Import Order created successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex) 
            { 
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void supplier_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoadService()
        {
            var dbContext = new DBContext();
            var productRepository = new ProductRepository(dbContext);
            _productService = new ProductService(productRepository);
            _bindingSource = new BindingSource();
            _product = new Product();
            var importOrderRepository = new ImportOrderRepository(dbContext);
            importOrderService = new ImportOrderService(importOrderRepository, _product);
            _importOrder = new ImportOrder();
            _importOrder.ImportOrderDetail = new List<ImportOrderDetail>(); // Thêm dòng này
        }
    }
}

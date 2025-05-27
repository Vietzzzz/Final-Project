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
            error_message_label.Visible = false;
            
            // Turn off autocolumn
            product_datagridview.AutoGenerateColumns = false;

            // Xóa tất cả cột hiện có
            product_datagridview.Columns.Clear();

            // select full row
            product_datagridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Add columns to datagridview
            product_datagridview.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "ProductId",
                HeaderText = "Product ID",
                DataPropertyName = "ProductId",
                Width = 100,
                ReadOnly = true,
            });

            product_datagridview.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "ProductName",
                HeaderText = "Product Name",
                DataPropertyName = "ProductName",
                Width = 200,
                ReadOnly = true,
            });

            product_datagridview.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Quantity",
                HeaderText = "Quantity",
                DataPropertyName = "Quantity",
                Width = 100,
            });

            product_datagridview.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Price",
                HeaderText = "Price",
                DataPropertyName = "UnitPrice",
                Width = 100,
                ReadOnly = true,
            });

            product_datagridview.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "TotalPrice",
                HeaderText = "Total Cost",
                DataPropertyName = "TotalPrice",
                Width = 100,
                ReadOnly = true,
            });

            // assign data source
            _bindingSource.DataSource = _importOrder.ImportOrderDetail;
            product_datagridview.DataSource = _bindingSource;

            // event when user edit quantity
            product_datagridview.CellValueChanged += Product_datagridview_CellValueChanged;

            // Định dạng cột Price thành 0,000 đ
            product_datagridview.Columns["Price"].DefaultCellStyle.Format = "#,##0 đ";
            product_datagridview.Columns["TotalPrice"].DefaultCellStyle.Format = "#,##0 đ";

            create_date_label.Text = DateTime.Now.ToString("dd/MM/yyyy");

            name_textbox.KeyDown += Name_textbox_KeyDown;
        }

        // Handle Enter key press in name_textbox
        private void Name_textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Ngăn âm thanh beep

                // Chỉ gọi sự kiện click nếu TextBox không trống
                if (!string.IsNullOrWhiteSpace(name_textbox.Text))
                {
                    add_button_Click(sender, e);
                }
            }
        }

        private void Product_datagridview_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == product_datagridview.Columns["Quantity"].Index)
            {
                int quantity;
                if (int.TryParse(product_datagridview.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString(), out quantity) && quantity <= 0
                    || quantity > 9999999)
                {
                    error_message_label.Text = "Invalid Quantity";
                    error_message_label.Visible = true;
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
            string name = name_textbox.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                error_message_label.Text = "Please enter product name";
                error_message_label.Visible = true;
                name_textbox.Focus();
                return;
            }

            try
            {
                // List product search by name
                List<Product> products = _productService.SearchProductByName(name);

                if (products.Count == 0)
                {
                    error_message_label.Text = "Product not found";
                    error_message_label.Visible = true;
                    name_textbox.Clear(); // Chọn toàn bộ text để người dùng có thể nhập lại
                    name_textbox.Focus();
                    return;
                }

                if (products.Count > 0)
                {
                    AddProductToOrder(products[0]);
                    error_message_label.Visible = false;
                }

                name_textbox.Clear();
                name_textbox.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    ProductName = product.ProductName,
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
                error_message_label.Text = "Please select a product to delete";
                error_message_label.Visible = true;
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
                error_message_label.Text = "Please enter supplier name";
                error_message_label.Visible = true;
                return;
            }
            // check if any product in order
            if (_importOrder.ImportOrderDetail.Count == 0)
            {
                error_message_label.Text = "Please add product to order";
                error_message_label.Visible = true;
                return;
            }

            // Kiểm tra CurrentAdmin
            if (SectionManager.Instance?.CurrentAdmin == null)
            {
                MessageBox.Show("You need to be logged in to save order", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Show confirmation dialog
            DialogResult result = MessageBox.Show("Are you sure you want to save this order?", "Confirm Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                return; // Exit if user clicks No
            }

            try
            {
                // Update infor
                _importOrder.CreatedAt = DateTime.Now;
                _importOrder.AdminId = SectionManager.Instance.CurrentAdmin.AdminId;
                _importOrder.SupplierName = supplier_textbox.Text.Trim();

                int orderId = importOrderService.CreateImportOrder(_importOrder);

                if (orderId > 0)
                {
                    MessageBox.Show("Import Order created successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

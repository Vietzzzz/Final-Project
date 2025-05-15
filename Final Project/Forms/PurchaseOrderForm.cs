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
        private List<Product> OriginalProducts = new List<Product>();
        private IProductService _productService;
        private Product _product;
        private SectionManager _sectionManager;
        public PurchaseOrderForm()
        {
            InitializeComponent();
            fail_label.Hide();
            error_message_label.Hide();

            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                LoadProductService();
            }
        }

        private void PurchaseOrderForm_Load(object sender, EventArgs e)
        {

        }

        // Display datagridview
        private void DisplayProduct(List<Product> products)
        {
            // Lưu trữ các giá trị quantity và totalPrice hiện tại
            Dictionary<string, object[]> savedValues = new Dictionary<string, object[]>();

            foreach (DataGridViewRow row in product_datagridview.Rows)
            {
                if (!row.IsNewRow)
                {
                    var product = row.DataBoundItem as Product;
                    if (product != null)
                    {
                        // Lưu productId, quantity và totalPrice
                        savedValues[product.ProductId.ToString()] = new object[] {
                    row.Cells["Quantity"].Value,
                    row.Cells["TotalPrice"].Value
                };
                    }
                }
            }
            product_datagridview.DataSource = products;
            // Turn off autogenerate columns
            product_datagridview.AutoGenerateColumns = false;

            // Delete existing columns
            product_datagridview.Columns.Clear();

            // Create productID column
            product_datagridview.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "ProductId",
                HeaderText = "ProductID",
                Width = 100,
                ReadOnly = true
            });

            // Create productName column
            product_datagridview.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "ProductName",
                HeaderText = "ProductName",
                Width = 200,
                ReadOnly = true
            });

            // Create price column
            product_datagridview.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Price",
                DataPropertyName = "Price",
                HeaderText = "Price",
                Width = 100,
                ReadOnly = true
            });

            // Create quantity column
            product_datagridview.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Quantity",
                HeaderText = "Quantity",
                Width = 100,
            });

            // Create total price column
            product_datagridview.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "TotalPrice",
                HeaderText = "Total Price",
                Width = 100,
                ReadOnly = true
            });

            // Thêm dòng này vào cuối đoạn code hiện tại
            foreach (DataGridViewRow row in product_datagridview.Rows)
            {
                if (!row.IsNewRow)
                {
                    var product = row.DataBoundItem as Product;
                    if (product != null)
                    {
                        string productId = product.ProductId.ToString();

                        if (savedValues.ContainsKey(productId))
                        {
                            // Khôi phục giá trị đã lưu cho sản phẩm đã tồn tại
                            row.Cells["Quantity"].Value = savedValues[productId][0];
                            row.Cells["TotalPrice"].Value = savedValues[productId][1];
                        }
                        else
                        {
                            // Đặt giá trị mặc định chỉ cho sản phẩm mới
                            row.Cells["Quantity"].Value = 1;
                            row.Cells["TotalPrice"].Value = product.Price * 1;
                        }
                    }
                }
            }
            product_datagridview.Columns["Price"].DefaultCellStyle.Format = "#,##0 đ";
            product_datagridview.Columns["TotalPrice"].DefaultCellStyle.Format = "#,##0 đ";

            product_datagridview.CellValueChanged += CalculateTotalPrice;
            totalprice_purchase_order.Text = UpdateTotalAmount().ToString("#,##0 đ");

        }
        // Calcaulate total price of 1 order detail
        private void CalculateTotalPrice(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && product_datagridview.Columns[e.ColumnIndex].Name == "Quantity")
            {
                var row = product_datagridview.Rows[e.RowIndex];
                var product = row.DataBoundItem as Product;

                if (product != null)
                {
                    // Lấy giá trị quantity do người dùng nhập
                    int quantity = 1; // Mặc định là 1
                    if (row.Cells["Quantity"].Value != null)
                    {
                        int.TryParse(row.Cells["Quantity"].Value.ToString(), out quantity);
                        if (quantity <= 0) quantity = 1; // Đảm bảo quantity luôn > 0
                    }

                    // Chỉ cập nhật Total Price, không ghi đè Quantity
                    row.Cells["TotalPrice"].Value = product.Price * quantity;
                }
                totalprice_purchase_order.Text = UpdateTotalAmount().ToString("#,##0 đ");
            }
        }
        // Total Pric Order
        private int UpdateTotalAmount()
        {
            int total = 0;

            // Duyệt qua tất cả các dòng trong DataGridView
            foreach (DataGridViewRow row in product_datagridview.Rows)
            {
                if (!row.IsNewRow)
                {
                    // Lấy giá trị TotalPrice (đã nhân với số lượng)
                    if (row.Cells["TotalPrice"].Value != null)
                    {
                        total += Convert.ToInt32(row.Cells["TotalPrice"].Value);
                    }
                }
            }
            return total;
        }
        // Add new purchase order
        private void add_button_Click(object sender, EventArgs e)
        {
            List<Product> currentProducts = new List<Product>();
            string name = name_textbox.Text;
            
            if (string.IsNullOrEmpty(name))
            {
                fail_label.Show();
                error_message_label.Text = "Please enter product name";
                error_message_label.Show();
                return;
            }

            if (OriginalProducts.Count == 0)
            {
                OriginalProducts = _productService.SearchProducts(name, null, null, null, null, null);
            }
            else
            {
                currentProducts = _productService.SearchProducts(name, null, null, null, null, null);
                OriginalProducts.AddRange(currentProducts.Where(cur => !OriginalProducts.Any(ori => ori.ProductId == cur.ProductId)));
            }
            DisplayProduct(OriginalProducts);
            fail_label.Hide();
            error_message_label.Hide();

        }
        private void supplier_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoadProductService()
        {
            var dbContext = new DBContext();
            var productRepository = new ProductRepository(dbContext);
            _productService = new ProductService(productRepository);
            _product = new Product(); // Tạo mới đối tượng product
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final_Project.BussinessLogic.Interfaces;
using Final_Project.BussinessLogic.Services;
using Final_Project.DataAccess;
using Final_Project.DataAccess.Repositories;
using Final_Project.Models;
using Final_Project.Forms;

namespace Final_Project.UserControlForms
{
    public partial class ProductUserControl : UserControl
    {
        private IProductService _productService;
        private Product _product;
        public ProductUserControl()
        {
            InitializeComponent();

            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                LoadProductService();
                // Khởi tạo DataGridView
                DisplayProduct(_productService.GetAllProducts());
            }
        }
        private void DisplayProduct(List<Product> products)
        {
            this.product_data_gridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.product_data_gridview.ReadOnly = true;

            product_data_gridview.DataSource = products;

            // Hidden Columns
            product_data_gridview.Columns["UpdateDate"].Visible = false;

            // Fill GridView Space
            product_data_gridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            product_data_gridview.Columns["CreatedDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // Định dạng cột Price thành 0,000 đ
            product_data_gridview.Columns["Price"].DefaultCellStyle.Format = "#,##0 đ";
        }

        private void add_product_button_Click(object sender, EventArgs e)
        {
            _product = new Product();
            // Code to add product
            _product.ProductName = name_textbox.Text;
            _product.Category = category_textbox.Text;
            _product.Unit = unit_textbox.Text;

            _product.Quantity = (int)quantity_textbox.Value;
            _product.Price = (int)price_textbox.Value;
            _product.Weight = (int)weight_textbox.Value;

            int productId = _productService.AddProduct(_product);
            DisplayProduct(_productService.GetAllProducts());
            ClearForm();
        }
        private void ClearForm()
        {
            name_textbox.Clear();
            category_textbox.Clear();
            unit_textbox.Clear();
            category_textbox.Clear();
            unit_textbox.Clear();

            weight_textbox.Value = 0;
            quantity_textbox.Value = 0;
            price_textbox.Value = 0;
        }
        // delete product
        private void delete_product_button_Click(object sender, EventArgs e)
        {
            if (product_data_gridview.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please choose a product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                Product delete_product = product_data_gridview.SelectedRows[0].DataBoundItem as Product;
                int productID = _productService.DeleteProduct(delete_product);
                DisplayProduct(_productService.GetAllProducts());
            }
        }
        private void LoadProductService()
        {
            var dbContext = new DBContext();
            var productRepository = new ProductRepository(dbContext);
            _productService = new ProductService(productRepository);
            _product = new Product(); // Tạo mới đối tượng product
        }
        // Search product
        private void search_button_Click(object sender, EventArgs e)
        {
            string name = name_textbox.Text;
            string category = category_textbox.Text;
            string unit = unit_textbox.Text;

            int? price = price_textbox.Value > 0 ? (int?)price_textbox.Value : null;
            int? quantity = quantity_textbox.Value > 0 ? (int?)quantity_textbox.Value : null;
            int? weight = weight_textbox.Value > 0 ? (int?)weight_textbox.Value : null; 

            List<Product> products = _productService.SearchProducts(name, category, unit, price, quantity, weight);
            DisplayProduct(products);
        }

        private void import_button_Click(object sender, EventArgs e)
        {
            PurchaseOrderForm purchaseOrderForm = new PurchaseOrderForm();
            purchaseOrderForm.ShowDialog();

            DisplayProduct(_productService.GetAllProducts());
        }
    }
}

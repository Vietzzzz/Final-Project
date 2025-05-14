using Final_Project.DataAccess.Interfaces;
using Final_Project.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.DataAccess.Repositories
{
    internal class ProductRepository : IProductRepository
    {
        private DBContext dbContext;
        public ProductRepository(DBContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public int CreateProduct(Product product)
        {
            int newProductId = 0;
            using (var conn = dbContext.GetConnection())
            {
                conn.Open();

                string query = "INSERT INTO product(product_name, unit, quantity, price, category, weight)" +
                               "VALUES (@product_name, @unit, @quantity, @price, @category, @weight)";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@product_name", product.ProductName);
                    cmd.Parameters.AddWithValue("@unit", product.Unit);
                    cmd.Parameters.AddWithValue("@quantity", product.Quantity);
                    cmd.Parameters.AddWithValue("@price", product.Price);
                    cmd.Parameters.AddWithValue("@category", product.Category);
                    cmd.Parameters.AddWithValue("@weight", product.Weight);

                    cmd.ExecuteNonQuery();

                    newProductId = product.ProductId; // Assuming ProductId is set after insertion
                }
            }
            return newProductId;
        }

        // Get All Product
        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();
            using (var conn = dbContext.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM product ORDER BY product_id";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Product product = new Product
                            {
                                ProductId = reader.GetInt32(0),
                                ProductName = reader.GetString(1),
                                Unit = reader.GetString(2),
                                Quantity = reader.GetInt32(3),
                                Price = reader.GetInt32(4),
                                CreatedDate = reader.GetDateTime(5),
                                UpdateDate = reader.GetDateTime(6),
                                Category = reader.GetString(7),
                                Weight = reader.GetInt32(8)
                            };
                            products.Add(product); // Thêm sản phẩm vào danh sách
                        }
                    }
                }
            }
            return products; // Trả về danh sách sản phẩm
        }
        // Delete Product
        public int DeleteProduct(Product product)
        {
            using (var conn = dbContext.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM product WHERE product_id = @product_id";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@product_id", product.ProductId);

                    cmd.ExecuteNonQuery();
                    return product.ProductId;
                }
            }
        }
    }
}

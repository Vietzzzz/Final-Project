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
        // Search Product
        public List<Product> SearchProducts(string name = null, string category = null,
                                     string unit = null, int? price = null,
                                     int? quantity = null, int? weight = null)
        {
            List<Product> products = new List<Product>();
            StringBuilder queryBuilder = new StringBuilder();
            List<NpgsqlParameter> parameters = new List<NpgsqlParameter>();

            // Truy vấn cơ bản
            queryBuilder.Append("SELECT * FROM product WHERE 1=1");

            // Thêm điều kiện tìm kiếm theo tên sản phẩm
            if (!string.IsNullOrEmpty(name))
            {
                queryBuilder.Append(" AND product_name ILIKE @productName");
                parameters.Add(new NpgsqlParameter("@productName", "%" + name + "%"));
            }

            if (!string.IsNullOrEmpty(category))
            {
                queryBuilder.Append(" AND product_name ILIKE @productName");
                parameters.Add(new NpgsqlParameter("@productName", "%" + category + "%"));
            }

            if (!string.IsNullOrEmpty(unit))
            {
                queryBuilder.Append(" AND product_name ILIKE @productName");
                parameters.Add(new NpgsqlParameter("@productName", "%" + unit + "%"));
            }

            // Thêm điều kiện tìm kiếm theo giá
            if (price.HasValue)
            {
                queryBuilder.Append(" AND price = @price");
                parameters.Add(new NpgsqlParameter("@price", price.Value));
            }

            // Thêm điều kiện tìm kiếm theo cân nặng
            if (quantity.HasValue)
            {
                queryBuilder.Append(" AND quantity = @quantity");
                parameters.Add(new NpgsqlParameter("@quantity", quantity.Value));
            }

            // Thêm điều kiện tìm kiếm theo số lượng
            if (weight.HasValue)
            {
                queryBuilder.Append(" AND weight = @weight");
                parameters.Add(new NpgsqlParameter("@weight", weight.Value));
            }

            using (var conn = dbContext.GetConnection())
            {
                conn.Open();

                using (var cmd = new NpgsqlCommand(queryBuilder.ToString(), conn))
                {
                    // Thêm tất cả tham số vào command
                    foreach (var parameter in parameters)
                    {
                        cmd.Parameters.Add(parameter);
                    }

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
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
                                // Thêm các thuộc tính khác tùy thuộc vào cấu trúc bảng của bạn
                            };

                            products.Add(product);
                        }
                    }
                }
            }

            return products;
        }
        // Get Product By ID
        public Product GetProductByID(int id)
        {
            Product product = null;

            using (var conn = dbContext.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM product WHERE product_id = @product_id";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@product_id", id);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            product = new Product
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
                        }
                        reader.Close();
                    }
                }
                return product;
            }
        }
        //Get Product By Name
        public List<Product> GetProductsByName(string name)
        {
            List<Product> products = new List<Product>();

            using (var conn = dbContext.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM product WHERE product_name ILIKE @product_name";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@product_name", "%" + name + "%");

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
                            products.Add(product);
                        }
                    }
                }
            }
            return products;
        }
        // Update Product Stock
        public void UpdateProductStock(int productId, int quantity)
        {
            using (var conn = dbContext.GetConnection())
            {
                conn.Open();
                string query = "UPDATE product SET quantity = @quantity + quantity WHERE product_id = @product_id";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@quantity", quantity);
                    cmd.Parameters.AddWithValue("@product_id", productId);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        // Update Product
    }
}

using Final_Project.DataAccess.Interfaces;
using System;
using Final_Project.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Npgsql;

namespace Final_Project.DataAccess.Repositories
{
    internal class ImportOrderRepository : IImportOrderRepository
    {
        DBContext dbContext = new DBContext();
        public ImportOrderRepository(DBContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public int CreateImportOrder(ImportOrder order)
        {
            int orderId = 0;

            // Open a connection to the database
            using (var conn = dbContext.GetConnection())
            {
                conn.Open();
                NpgsqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // add new order
                    string query = "INSERT INTO purchase_order (order_id, adminid, created_at, total_price, total_quantity, supplier) " +
                                   "VALUES (@orderId, @adminId, @createdAt, @totalPrice, totalQuantity, @supplier)";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@orderId", order.OrderId);
                        cmd.Parameters.AddWithValue("@adminId", order.AdminId);
                        cmd.Parameters.AddWithValue("@createdAt", order.CreatedAt);
                        cmd.Parameters.AddWithValue("@totalPrice", order.TotalPrice);
                        cmd.Parameters.AddWithValue("@totalQuantity", order.TotalQuantity);
                        cmd.Parameters.AddWithValue("@supplier", order.SupplierName);

                        cmd.ExecuteNonQuery();
                    }
                    orderId = order.OrderId;

                    // Add detail order
                    foreach (var detail in order.ImportOrderDetail)
                    {
                        string detailQuery = "INSERT INTO purchase_order_detail (detail_id, order_id, product_id, quantity, unit_price) " +
                                             "VALUES (@detailId, @orderId, @productId, @quantity, @unitPrice)";
                        using (var cmd = new NpgsqlCommand(detailQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@detailId", detail.DetailId);
                            cmd.Parameters.AddWithValue("@orderId", detail.OrderId);
                            cmd.Parameters.AddWithValue("@productId", detail.ProductId);
                            cmd.Parameters.AddWithValue("@quantity", detail.Quantity);
                            cmd.Parameters.AddWithValue("@unitPrice", detail.UnitPrice);

                            cmd.ExecuteNonQuery();
                        }
                        // Update stock
                        string updateQuery = "update product set quantity = quantity + @quantity where product_id = @productId";
                        using (var cmd = new NpgsqlCommand(updateQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@quantity", detail.Quantity);
                            cmd.Parameters.AddWithValue("@productId", detail.ProductId);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    // error when create order
                    transaction.Rollback();
                    throw new Exception("Error: " + ex.Message);
                }
            }

            return orderId;
        }

        public ImportOrder GetOrderById(int id)
        {
            ImportOrder order = null;
            using (var conn = dbContext.GetConnection())
            {
                conn.Open();

                string query = "SELECT * FROM purchase_order WHERE order_id = @orderId";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@orderId", id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            order = new ImportOrder
                            {
                                OrderId = reader.GetInt32(0),
                                AdminId = reader.GetInt32(1),
                                CreatedAt = reader.GetDateTime(2),
                                TotalPrice = reader.GetInt32(3),
                                TotalQuantity = reader.GetInt32(4),
                                SupplierName = reader.GetString(5)
                            };
                        }
                        reader.Close();
                        if (order != null)
                        {
                            // Get order details
                            string detailOrderQuery = "SELECT d.detail_id, d.order_id, d.product_id, d.quantity, d.unit_price, p.product_name" +
                                                      "FROM purchase_order_detail d" +
                                                      "JOIN product ON p on d.product_id = p.product_id" +
                                                      "WHERE order_id = @orderId";

                            using (var detailCmd = new NpgsqlCommand(detailOrderQuery, conn))
                            {
                                detailCmd.Parameters.AddWithValue("@orderId", order.OrderId);
                                using (var detailReader = detailCmd.ExecuteReader())
                                {
                                    while (detailReader.Read())
                                    {
                                        ImportOrderDetail detail = new ImportOrderDetail
                                        {
                                            DetailId = Convert.ToInt32(detailReader["detail_id"]),
                                            OrderId = Convert.ToInt32(detailReader["order_id"]),
                                            ProductId = Convert.ToInt32(detailReader["product_id"]),
                                            Quantity = Convert.ToInt32(detailReader["quantity"]),
                                            UnitPrice = Convert.ToInt32(detailReader["unit_price"]),

                                            Product = new Product
                                            {
                                                ProductId = Convert.ToInt32(detailReader["product_id"]),
                                                ProductName = reader["product_name"].ToString(),
                                                Price = Convert.ToInt32(detailReader["price"])
                                            }
                                        };
                                        order.ImportOrderDetail.Add(detail);
                                    }
                                    detailReader.Close();
                                }
                            }
                        }
                    }
                }

                return order;
            }
        }
    }
}

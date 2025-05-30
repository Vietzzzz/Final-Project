using Final_Project.DataAccess.Interfaces;
using System;
using Final_Project.Models;
using Npgsql;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.DataAccess.Repositories
{
    public class ExportOrderRepository : IExportOrderRepository
    {
        DBContext dbContext = new DBContext();
        public ExportOrderRepository(DBContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public int CreateExportOrder(ExportOrder order)
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
                    string query = "INSERT INTO export_order (adminid, created_at, total_price, total_quantity, delivery_address) " +
                                   "VALUES (@adminId, @createdAt, @totalPrice, @totalQuantity, @address) returning order_id";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@adminId", order.AdminId);
                        cmd.Parameters.AddWithValue("@createdAt", order.CreatedAt);
                        cmd.Parameters.AddWithValue("@totalPrice", order.TotalPrice);
                        cmd.Parameters.AddWithValue("@totalQuantity", order.TotalQuantity);
                        cmd.Parameters.AddWithValue("@address", order.Address);

                        orderId = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    // Add detail order
                    foreach (var detail in order.ExportOrderDetail)
                    {
                        string detailQuery = "INSERT INTO export_order_details (order_id, product_id, quantity, unit_price, product_name) " +
                                             "VALUES (@orderId, @productId, @quantity, @unitPrice, @productName)";
                        using (var cmd = new NpgsqlCommand(detailQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@orderId", orderId); // Sử dụng orderId đã lấy được
                            cmd.Parameters.AddWithValue("@productId", detail.ProductId);
                            cmd.Parameters.AddWithValue("@quantity", detail.Quantity);
                            cmd.Parameters.AddWithValue("@unitPrice", detail.UnitPrice);
                            cmd.Parameters.AddWithValue("@productName", detail.ProductName);

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

        public ExportOrder GetOrderById(int id)
        {
            ExportOrder order = null;
            using (var conn = dbContext.GetConnection())
            {
                conn.Open();

                string query = "SELECT * FROM export_order WHERE order_id = @orderId";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@orderId", id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            order = new ExportOrder
                            {
                                OrderId = reader.GetInt32(0),
                                AdminId = reader.GetInt32(1),
                                CreatedAt = reader.GetDateTime(2),
                                TotalPrice = reader.GetInt32(3),
                                TotalQuantity = reader.GetInt32(4),
                                Address = reader.GetString(5)
                            };
                        }
                        reader.Close();
                        if (order != null)
                        {
                            // Get order details
                            string detailOrderQuery = "SELECT d.detail_id, d.order_id, d.product_id, d.quantity, d.unit_price, d.product_name" +
                                                      "FROM export_order_details d" +
                                                      "JOIN product p on d.product_id = p.product_id" +
                                                      "WHERE order_id = @orderId";

                            using (var detailCmd = new NpgsqlCommand(detailOrderQuery, conn))
                            {
                                detailCmd.Parameters.AddWithValue("@orderId", order.OrderId);
                                using (var detailReader = detailCmd.ExecuteReader())
                                {
                                    while (detailReader.Read())
                                    {
                                        ExportOrderDetail detail = new ExportOrderDetail
                                        {
                                            DetailId = Convert.ToInt32(detailReader["detail_id"]),
                                            OrderId = Convert.ToInt32(detailReader["order_id"]),
                                            ProductId = Convert.ToInt32(detailReader["product_id"]),
                                            Quantity = Convert.ToInt32(detailReader["quantity"]),
                                            UnitPrice = Convert.ToInt32(detailReader["unit_price"]),
                                            ProductName = detailReader["d.product_name"].ToString(),

                                            Product = new Product
                                            {
                                                ProductId = Convert.ToInt32(detailReader["product_id"]),
                                                ProductName = detailReader["product_name"].ToString(),
                                                Price = Convert.ToInt32(detailReader["price"])
                                            }
                                        };
                                        order.ExportOrderDetail.Add(detail);
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

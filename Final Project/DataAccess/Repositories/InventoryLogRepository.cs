using Final_Project.DataAccess.Interfaces;
using Final_Project.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.DataAccess.Repositories
{
    public class InventoryLogRepository : IInventoryLogRepository
    {
        private DBContext dbContext;
        public InventoryLogRepository(DBContext dbContext)
        {
            this.dbContext = dbContext;
        }
        // Chạy stored procedure để cập nhật inventory và tạo log
        public void UpdateInventoryAndLog(int purchaseOrderId, int adminId)
        {
            using (var conn = dbContext.GetConnection())
            {
                conn.Open();
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        string procedureCall = "CALL update_inventory_and_log(@p_purchase_order_id, @p_admin_id)";

                        using (var cmd = new NpgsqlCommand(procedureCall, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@p_purchase_order_id", purchaseOrderId);
                            cmd.Parameters.AddWithValue("@p_admin_id", adminId);

                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Error executing inventory update: " + ex.Message);
                    }
                }
            }
        }

        // Lấy tất cả inventory logs để hiển thị trên DataGridView
        public List<InventoryLog> GetAllInventoryLogs()
        {
            List<InventoryLog> logs = new List<InventoryLog>();

            using (var conn = dbContext.GetConnection())
            {
                conn.Open();
                string query = @"SELECT 
                                    log_id,
                                    product_id,
                                    product_name,
                                    quantity_added,
                                    old_quantity,
                                    new_quantity,
                                    unit_price,
                                    order_id,
                                    admin_id,
                                    supplier,
                                    created_at
                                FROM inventory_log 
                                ORDER BY created_at DESC";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            InventoryLog log = new InventoryLog
                            {
                                LogId = reader.GetInt32(reader.GetOrdinal("log_id")),
                                ProductId = reader.GetInt32(reader.GetOrdinal("product_id")),
                                ProductName = reader.GetString(reader.GetOrdinal("product_name")),
                                QuantityAdded = reader.GetInt32(reader.GetOrdinal("quantity_added")),
                                OldQuantity = reader.GetInt32(reader.GetOrdinal("old_quantity")),
                                NewQuantity = reader.GetInt32(reader.GetOrdinal("new_quantity")),
                                UnitPrice = reader.GetDecimal(reader.GetOrdinal("unit_price")),
                                OrderId = reader.GetInt32(reader.GetOrdinal("order_id")),
                                Supplier = reader.GetString(reader.GetOrdinal("supplier")),
                                CreatedAt = reader.GetDateTime(reader.GetOrdinal("created_at"))
                            };
                            logs.Add(log);
                        }
                    }
                }
            }

            return logs;
        }

        // Lấy inventory logs theo order ID
        public List<InventoryLog> GetInventoryLogsByOrderId(int orderId)
        {
            List<InventoryLog> logs = new List<InventoryLog>();

            using (var conn = dbContext.GetConnection())
            {
                conn.Open();
                string query = @"SELECT 
                                    log_id,
                                    product_id,
                                    product_name,
                                    quantity_added,
                                    old_quantity,
                                    new_quantity,
                                    unit_price,
                                    order_id,
                                    admin_id,
                                    supplier,
                                    created_at
                                FROM inventory_log 
                                WHERE order_id = @orderId
                                ORDER BY created_at DESC";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@orderId", orderId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            InventoryLog log = new InventoryLog
                            {
                                LogId = reader.GetInt32(reader.GetOrdinal("log_id")),
                                ProductId = reader.GetInt32(reader.GetOrdinal("product_id")),
                                ProductName = reader.GetString(reader.GetOrdinal("product_name")),
                                QuantityAdded = reader.GetInt32(reader.GetOrdinal("quantity_added")),
                                OldQuantity = reader.GetInt32(reader.GetOrdinal("old_quantity")),
                                NewQuantity = reader.GetInt32(reader.GetOrdinal("new_quantity")),
                                UnitPrice = reader.GetDecimal(reader.GetOrdinal("unit_price")),
                                OrderId = reader.GetInt32(reader.GetOrdinal("order_id")),
                                Supplier = reader.GetString(reader.GetOrdinal("supplier")),
                                CreatedAt = reader.GetDateTime(reader.GetOrdinal("created_at"))
                            };
                            logs.Add(log);
                        }
                    }
                }
            }

            return logs;
        }

        // Tạo DataTable để bind với DataGridView
        public DataTable GetInventoryLogsAsDataTable()
        {
            DataTable dataTable = new DataTable();

            using (var conn = dbContext.GetConnection())
            {
                conn.Open();
                string query = @"SELECT 
                                    log_id as ""Log ID"",
                                    product_id as ""Product ID"",
                                    product_name as ""Product Name"",
                                    quantity_added as ""Quantity Added"",
                                    old_quantity as ""Old Quantity"",
                                    new_quantity as ""New Quantity"",
                                    unit_price as ""Unit Price"",
                                    order_id as ""Order ID"",
                                    supplier as ""Supplier"",
                                    created_at as ""Created At""
                                FROM inventory_log ";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    using (var adapter = new NpgsqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }

    }
}

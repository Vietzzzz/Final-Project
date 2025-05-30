using Final_Project.DataAccess.Interfaces;
using Final_Project.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;


namespace Final_Project.DataAccess.Repositories
{
    internal class ExportLogRepository : IExportLogRepository
    {
        private DBContext dbContext;
        public ExportLogRepository(DBContext dbContext)
        {
            this.dbContext = dbContext;
        }
        // Chạy stored procedure để cập nhật inventory và tạo log
        public void UpdateInventoryAndLog(int exportOrderId, int adminId)
        {
            using (var conn = dbContext.GetConnection())
            {
                conn.Open();
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        string procedureCall = "CALL export_inventory_and_log(@p_export_order_id, @p_admin_id)";

                        using (var cmd = new NpgsqlCommand(procedureCall, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@p_export_order_id", exportOrderId);
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
        public List<ExportLog> GetAllInventoryLogs()
        {
            List<ExportLog> logs = new List<ExportLog>();

            using (var conn = dbContext.GetConnection())
            {
                conn.Open();
                string query = @"SELECT 
                                    log_id,
                                    product_id,
                                    product_name,
                                    quantity_exported,
                                    old_quantity,
                                    new_quantity,
                                    unit_price,
                                    order_id,
                                    admin_id,
                                    delivery_address,
                                    created_at
                                FROM export_inventory_log 
                                ORDER BY created_at DESC";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ExportLog log = new ExportLog
                            {
                                LogId = reader.GetInt32(reader.GetOrdinal("log_id")),
                                AdminID = reader.GetInt32(reader.GetOrdinal("admin_id")),
                                ProductId = reader.GetInt32(reader.GetOrdinal("product_id")),
                                ProductName = reader.GetString(reader.GetOrdinal("product_name")),
                                QuantityExported = reader.GetInt32(reader.GetOrdinal("quantity_exported")),
                                OldQuantity = reader.GetInt32(reader.GetOrdinal("old_quantity")),
                                NewQuantity = reader.GetInt32(reader.GetOrdinal("new_quantity")),
                                UnitPrice = reader.GetDecimal(reader.GetOrdinal("unit_price")),
                                OrderId = reader.GetInt32(reader.GetOrdinal("order_id")),
                                Address = reader.GetString(reader.GetOrdinal("delivery_address")),
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
        public List<ExportLog> GetExportLogsByOrderId(int orderId)
        {
            List<ExportLog> logs = new List<ExportLog>();

            using (var conn = dbContext.GetConnection())
            {
                conn.Open();
                string query = @"SELECT 
                                    log_id,
                                    product_id,
                                    product_name,
                                    quantity_exported,
                                    old_quantity,
                                    new_quantity,
                                    unit_price,
                                    order_id,
                                    admin_id,
                                    delivery_address,
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
                            ExportLog log = new ExportLog
                            {
                                LogId = reader.GetInt32(reader.GetOrdinal("log_id")),
                                AdminID = reader.GetInt32(reader.GetOrdinal("admin_id")),
                                ProductId = reader.GetInt32(reader.GetOrdinal("product_id")),
                                ProductName = reader.GetString(reader.GetOrdinal("product_name")),
                                QuantityExported = reader.GetInt32(reader.GetOrdinal("quantity_exported")),
                                OldQuantity = reader.GetInt32(reader.GetOrdinal("old_quantity")),
                                NewQuantity = reader.GetInt32(reader.GetOrdinal("new_quantity")),
                                UnitPrice = reader.GetDecimal(reader.GetOrdinal("unit_price")),
                                OrderId = reader.GetInt32(reader.GetOrdinal("order_id")),
                                Address = reader.GetString(reader.GetOrdinal("delivery_address")),
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
                                    admin_id as ""AdminID"",
                                    product_name as ""Product Name"",
                                    quantity_exported as ""Quantity Exported"",
                                    old_quantity as ""Old Quantity"",
                                    new_quantity as ""New Quantity"",
                                    unit_price as ""Unit Price"",
                                    order_id as ""Order ID"",
                                    delivery_address as ""Address"",
                                    created_at as ""Created At""
                                FROM export_inventory_log ";

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

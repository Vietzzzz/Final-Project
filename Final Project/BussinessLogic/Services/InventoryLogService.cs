using Final_Project.BussinessLogic.Interfaces;
using Final_Project.BussinessLogic.SectionManagerct;
using Final_Project.DataAccess.Interfaces;
using Final_Project.Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace Final_Project.BussinessLogic.Services
{
    public class InventoryLogService : IInventoryLogService
    {
        private IInventoryLogRepository _inventoryLogRepository;

        public InventoryLogService(IInventoryLogRepository inventoryLogRepository)
        {
            _inventoryLogRepository = inventoryLogRepository;
        }

        // Xử lý cập nhật inventory từ purchase order
        public void ProcessInventoryUpdate(int purchaseOrderId)
        {
            try
            {
                // Lấy admin ID từ session
                int adminId = SectionManager.Instance.CurrentAdmin.AdminId;

                // Gọi stored procedure để cập nhật inventory và tạo log
                _inventoryLogRepository.UpdateInventoryAndLog(purchaseOrderId, adminId);
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to process inventory update: {ex.Message}");
            }
        }

        // Lấy tất cả inventory logs
        public List<InventoryLog> GetAllInventoryLogs()
        {
            return _inventoryLogRepository.GetAllInventoryLogs();
        }

        // Lấy inventory logs theo order ID
        public List<InventoryLog> GetInventoryLogsByOrderId(int orderId)
        {
            if (orderId <= 0)
            {
                throw new ArgumentException("Order ID must be greater than 0");
            }

            return _inventoryLogRepository.GetInventoryLogsByOrderId(orderId);
        }

        // Lấy dữ liệu dạng DataTable để hiển thị trên DataGridView
        public DataTable GetInventoryLogsForGrid()
        {
            return _inventoryLogRepository.GetInventoryLogsAsDataTable();
        }
    }
}
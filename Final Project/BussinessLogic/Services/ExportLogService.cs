using Final_Project.BussinessLogic.Interfaces;
using Final_Project.BussinessLogic.SectionManagerct;
using Final_Project.DataAccess.Interfaces;
using Final_Project.Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace Final_Project.BussinessLogic.Services
{
    public class ExportLogService : IExportLogService
    {
        private IExportLogRepository exportLogRepository;

        public ExportLogService(IExportLogRepository exportLogRepository)
        {
            this.exportLogRepository = exportLogRepository;
        }

        // Xử lý cập nhật inventory từ purchase order
        public void ProcessInventoryUpdate(int exportOrderId)
        {
            try
            {
                // Lấy admin ID từ session
                int adminId = SectionManager.Instance.CurrentAdmin.AdminId;

                // Gọi stored procedure để cập nhật inventory và tạo log
                exportLogRepository.UpdateInventoryAndLog(exportOrderId, adminId);
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to process inventory update: {ex.Message}");
            }
        }

        // Lấy tất cả inventory logs
        public List<ExportLog> GetAllInventoryLogs()
        {
            return exportLogRepository.GetAllInventoryLogs();
        }

        // Lấy inventory logs theo order ID
        public List<ExportLog> GetInventoryLogsByOrderId(int orderId)
        {
            if (orderId <= 0)
            {
                throw new ArgumentException("Order ID must be greater than 0");
            }

            return exportLogRepository.GetExportLogsByOrderId(orderId);
        }

        // Lấy dữ liệu dạng DataTable để hiển thị trên DataGridView
        public DataTable GetInventoryLogsForGrid()
        {
            return exportLogRepository.GetInventoryLogsAsDataTable();
        }
    }
}

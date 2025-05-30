using Final_Project.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.DataAccess.Interfaces
{
    public interface IExportLogRepository
    {
        void UpdateInventoryAndLog(int exportOrderId, int adminId);
        List<ExportLog> GetAllInventoryLogs();
        List<ExportLog> GetExportLogsByOrderId(int orderId);
        DataTable GetInventoryLogsAsDataTable();
    }
}

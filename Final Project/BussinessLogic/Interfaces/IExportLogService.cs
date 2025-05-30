using Final_Project.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.BussinessLogic.Interfaces
{
    public interface IExportLogService
    {
        void ProcessInventoryUpdate(int exportOrderId);
        List<ExportLog> GetAllInventoryLogs();
        List<ExportLog> GetInventoryLogsByOrderId(int orderId);
        DataTable GetInventoryLogsForGrid();
    }
}

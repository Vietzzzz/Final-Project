using Final_Project.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.DataAccess.Interfaces
{
    public interface IInventoryLogRepository
    {
        void UpdateInventoryAndLog(int purchaseOrderId, int adminId);
        List<InventoryLog> GetAllInventoryLogs();
        List<InventoryLog> GetInventoryLogsByOrderId(int orderId);
        DataTable GetInventoryLogsAsDataTable();
    }
}

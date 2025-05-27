using Final_Project.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.BussinessLogic.Interfaces
{
    public interface IInventoryLogService
    {
        void ProcessInventoryUpdate(int purchaseOrderId);
        List<InventoryLog> GetAllInventoryLogs();
        List<InventoryLog> GetInventoryLogsByOrderId(int orderId);
        DataTable GetInventoryLogsForGrid();
    }
}

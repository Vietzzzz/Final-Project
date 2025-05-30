using Final_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.DataAccess.Interfaces
{
    public interface IExportOrderRepository
    {
        int CreateExportOrder(ExportOrder order);
        ExportOrder GetOrderById(int id);
    }
}

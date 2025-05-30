using Final_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.BussinessLogic.Interfaces
{
    public interface IExportOrderService
    {
        int CreateExportOrder(ExportOrder order);
        ExportOrder GetExportOrderById(int id);
    }
}

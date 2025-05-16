using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final_Project.Models;

namespace Final_Project.BussinessLogic.Interfaces
{
    public interface IImportOrderService
    {
        int CreateImportOrder(ImportOrder order);
        ImportOrder GetImportOrderById(int id);
    }
}

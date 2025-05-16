using Final_Project.BussinessLogic.Interfaces;
using Final_Project.BussinessLogic.SectionManagerct;
using Final_Project.DataAccess.Interfaces;
using Final_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.BussinessLogic.Services
{
    public class ImportOrderService : IImportOrderService
    {
        private IImportOrderRepository _importOrderRepository;
        private Product _product;

        public ImportOrderService(IImportOrderRepository importOrderRepositoryimportOrder, Product product)
        {
            _importOrderRepository = importOrderRepositoryimportOrder;
            _product = product;
        }

        // create import order
        public int CreateImportOrder(ImportOrder order)
        {
            // Validate the import order
            if (order.ImportOrderDetail.Count == 0)
            {
                throw new Exception("There is nothing to import");
            }

            // check supplier name
            if (string.IsNullOrEmpty(order.SupplierName))
            {
                throw new Exception("Supplier name is required");
            }


            order.AdminId = SectionManager.Instance.CurrentAdmin.AdminId;
            order.CreatedAt = DateTime.Now;

            // update stock
            order.UpdateTotal();

            return _importOrderRepository.CreateImportOrder(order);
        }
        // Get import order by id
        public ImportOrder GetImportOrderById(int id)
        {
            return _importOrderRepository.GetOrderById(id);
        }
    }
}

using Final_Project.BussinessLogic.Interfaces;
using Final_Project.BussinessLogic.SectionManagerct;
using Final_Project.DataAccess.Interfaces;
using Final_Project.DataAccess.Repositories;
using Final_Project.DataAccess;
using Final_Project.Models;
using System;


namespace Final_Project.BussinessLogic.Services
{
    public class ExportOrderService : IExportOrderService
    {
        private IExportOrderRepository exportOrderRepository;
        private ProductRepository _productRepository;
        private Product _product;

        public ExportOrderService(IExportOrderRepository exportOrderRepository, Product product)
        {
            this.exportOrderRepository = exportOrderRepository;
            _product = product;

            // Thêm ProductRepository để update stock
            var dbContext = new DBContext();
            _productRepository = new ProductRepository(dbContext);
        }

        // create import order
        public int CreateExportOrder(ExportOrder order)
        {
            // Validate the import order
            if (order.ExportOrderDetail.Count == 0)
            {
                throw new Exception("There is nothing to export");
            }

            // check supplier name
            if (string.IsNullOrEmpty(order.Address))
            {
                throw new Exception("Address is required");
            }

            order.AdminId = SectionManager.Instance.CurrentAdmin.AdminId;
            order.CreatedAt = DateTime.Now;

            // update stock
            order.UpdateTotal();

            // Tạo order trước
            return exportOrderRepository.CreateExportOrder(order);
        }

        // Get import order by id
        public ExportOrder GetExportOrderById(int id)
        {
            return exportOrderRepository.GetOrderById(id);
        }
    }
}

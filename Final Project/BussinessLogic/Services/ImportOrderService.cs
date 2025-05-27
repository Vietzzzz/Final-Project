using Final_Project.BussinessLogic.Interfaces;
using Final_Project.BussinessLogic.SectionManagerct;
using Final_Project.DataAccess.Interfaces;
using Final_Project.DataAccess.Repositories;
using Final_Project.DataAccess;
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
        private ProductRepository _productRepository;
        private Product _product;

        public ImportOrderService(IImportOrderRepository importOrderRepository, Product product)
        {
            _importOrderRepository = importOrderRepository;
            _product = product;

            // Thêm ProductRepository để update stock
            var dbContext = new DBContext();
            _productRepository = new ProductRepository(dbContext);
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

            // Tạo order trước
            int orderId = _importOrderRepository.CreateImportOrder(order);

            if (orderId > 0)
            {
                // Sau khi tạo order thành công, update stock cho từng sản phẩm
                foreach (var detail in order.ImportOrderDetail)
                {
                    try
                    {
                        // Update stock với thông tin đầy đủ để trigger ghi log
                        _productRepository.UpdateProductStock(
                            productId: detail.ProductId,
                            quantity: detail.Quantity
                        );
                    }
                    catch (Exception ex)
                    {
                        throw new Exception($"Error updating stock for product {detail.ProductName}: {ex.Message}");
                    }
                }
            }

            return orderId;
        }

        // Get import order by id
        public ImportOrder GetImportOrderById(int id)
        {
            return _importOrderRepository.GetOrderById(id);
        }
    }
}
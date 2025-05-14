using Final_Project.BussinessLogic.Interfaces;
using Final_Project.Models;
using Final_Project.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Final_Project.BussinessLogic.Services
{
    internal class ProductService : IProductService
    {
        private IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public int AddProduct(Product product)
        {
            if (product.ProductName == null)
            {
                throw new ArgumentNullException("Product name cannot be null");
            }
            if (product.Price <= 0)
                throw new Exception("Price Must > 0");

            if (product.Quantity < 0)
                throw new Exception("Quantity Must > 0");

            if (product.Weight < 0)
                throw new Exception("Weight Must > 0");

            int productID = _productRepository.CreateProduct(product);
            return productID;
        }
        public List<Product> GetAllProducts()
        {

            return _productRepository.GetAllProducts();
        }
        public int DeleteProduct(Product product)
        {
            if (product.ProductId <= 0)
                throw new Exception("Product ID must be greater than 0");

            return _productRepository.DeleteProduct(product);
        }
    }
}

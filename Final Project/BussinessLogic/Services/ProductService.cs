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
        // get all products
        public List<Product> GetAllProducts()
        {

            return _productRepository.GetAllProducts();
        }
        // delete product
        public int DeleteProduct(Product product)
        {
            if (product.ProductId <= 0)
                throw new Exception("Product ID must be greater than 0");

            return _productRepository.DeleteProduct(product);
        }
        // search product
        public List<Product> SearchProducts(string name = null, string category = null,
                                     string unit = null, int? price = null,
                                     int? quantity = null, int? weight = null)
        {
            // Kiểm tra dữ liệu đầu vào nếu cần
            if (quantity.HasValue && quantity < 0)
            {
                throw new ArgumentException("Quantity must >= 0");
            }

            if (price.HasValue && quantity < 0)
            {
                throw new ArgumentException("Price must >= 0");
            }

            if (weight.HasValue && weight < 0)
            {
                throw new ArgumentException("Weight must >= 0");
            }

            // Gọi đến repository để thực hiện tìm kiếm
            return _productRepository.SearchProducts(
                name,
                category,
                unit,
                price,
                quantity,
                weight
            );
        }
        // get product by id
        public Product GetProductById(int productID)
        {
            return _productRepository.GetProductByID(productID);
        }
        // search product by name
        public List<Product> SearchProductByName(string name)
        {
            return _productRepository.GetProductsByName(name);
        }
    }
}

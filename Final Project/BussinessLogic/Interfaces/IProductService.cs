using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final_Project.Models;

namespace Final_Project.BussinessLogic.Interfaces
{
    internal interface IProductService
    {
        // add product
        int AddProduct(Product product);
        // get all product
        List<Product> GetAllProducts();
        // delete product
        int DeleteProduct(Product product);
        // search product
        List<Product> SearchProducts(string name = null, string category = null,
                                     string unit = null, int? price = null,
                                     int? quantity = null, int? weight = null);
        // get product by id
        Product GetProductById(int id);
        // search product by name
        List<Product> SearchProductByName(string name);
    }
}

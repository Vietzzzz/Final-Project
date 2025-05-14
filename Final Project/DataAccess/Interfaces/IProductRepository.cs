using Final_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.DataAccess.Interfaces
{
    public interface IProductRepository
    {
        int CreateProduct(Product product);
        List<Product> GetAllProducts();
        int DeleteProduct(Product product);
        List<Product> SearchProducts(string name = null, string category = null,
                                     string unit = null, int? price = null,
                                     int? quantity = null, int? weight = null);

    }
}

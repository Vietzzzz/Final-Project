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
        int AddProduct(Product product);
        List<Product> GetAllProducts();
        int DeleteProduct(Product product);
    }
}

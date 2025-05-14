using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final_Project.Models;

namespace Final_Project.DataAccess.Interfaces
{
    public interface IAdminRepository
    {
        Admin ValidateCredential(string username, string password);
    }
}

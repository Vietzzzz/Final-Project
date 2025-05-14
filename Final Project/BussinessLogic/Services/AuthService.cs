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
    public class AuthService : IAuthService
    {
        private readonly IAdminRepository _adminRepository;
        private readonly SectionManager _sSectionManager;

        public AuthService(IAdminRepository adminRepository, SectionManager sSectionManager)
        {
            _adminRepository = adminRepository;
            _sSectionManager = sSectionManager;
        }
        public bool ValidateUser(string username, string password)
        {
            var admin = _adminRepository.ValidateCredential(username, password);
            if (admin != null)
            {
                _sSectionManager.CurrentAdmin = admin;
                return true;
            }
            return false;
        }

        public Admin GetCurrentAdmin()
        {
            return _sSectionManager.CurrentAdmin;
        }
    }
}

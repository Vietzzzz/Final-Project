using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final_Project.BussinessLogic.SectionManagerct;
using Final_Project.BussinessLogic.Services;
using Final_Project.DataAccess.Repositories;
using Final_Project.Forms;
using Final_Project.DataAccess;

namespace Final_Project
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var dbContext = new DBContext();
            var adminRepository = new AdminRepository(dbContext);
            var sectionManager = new SectionManager();
            var authService = new AuthService(adminRepository, sectionManager);


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm(authService));

        }
    }
}

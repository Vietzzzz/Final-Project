using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final_Project.BussinessLogic.Interfaces;
using Final_Project.Models;

namespace Final_Project.BussinessLogic.SectionManagerct
{
    public class SectionManager
    {
        public Admin CurrentAdmin { get; set; }

        private static SectionManager _instance;
        public static SectionManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SectionManager();
                return _instance;
            }

        }
    }
}

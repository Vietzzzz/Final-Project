using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Final_Project.Models
{
    public class ExportOrder
    {
        public int OrderId { get; set; }
        public int AdminId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public int TotalPrice { get; set; }
        public int TotalQuantity { get; set; }
        public string Address { get; set; }

        // Navigation property cho mối quan hệ với bảng Admin
        public Admin Admin { get; set; }

        public List<ExportOrderDetail> ExportOrderDetail { get; set; }

        public void UpdateTotal()
        {
            TotalQuantity = 0;
            TotalPrice = 0;

            foreach (var detail in ExportOrderDetail)
            {
                TotalQuantity += detail.Quantity;
                TotalPrice += detail.UnitPrice * detail.Quantity;
            }
        }
    }

}

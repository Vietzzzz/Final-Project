using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Final_Project.Models
{
    public class ImportOrder
    {
        public int OrderId { get; set; }
        public int AdminId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public int TotalPrice { get; set; }
        public int TotalQuantity { get; set; }
        public string SupplierName {  get; set; }
        
        // Navigation property cho mối quan hệ với bảng Admin
        public Admin Admin { get; set; }
        
        public List<ImportOrderDetail> ImportOrderDetail { get; set; }

        public void UpdateTotal()
        {
            TotalQuantity = 0;
            TotalQuantity = 0;

            foreach (var detail in ImportOrderDetail)
            {
                TotalQuantity += detail.Quantity;
                TotalQuantity += detail.UnitPrice;
            }
        }
    }

}

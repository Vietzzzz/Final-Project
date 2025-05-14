using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Models
{
    public class PurchaseOrders
    {
        public int OrderId { get; set; }
        public int AdminId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public int TotalPrice { get; set; }
        public int TotalQuantity { get; set; }
        public string Supplier {  get; set; }
        
        // Navigation property cho mối quan hệ với bảng Admin
        public Admin Admin { get; set; }
        
        // Navigation property cho mối quan hệ với bảng OrderDetails
        public ICollection<PurchaseOrderDetails> PurchaseOrdersDetails { get; set; }
    }

}

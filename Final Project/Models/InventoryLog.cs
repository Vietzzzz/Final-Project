using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Models
{
    public class InventoryLog
    {
        public int LogId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int QuantityAdded { get; set; }
        public int OldQuantity { get; set; }
        public int NewQuantity { get; set; }
        public decimal UnitPrice { get; set; }
        public int? OrderId { get; set; }
        public string AdminName { get; set; }
        public string Supplier { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}

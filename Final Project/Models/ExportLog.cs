using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Models
{
    public class ExportLog
    {
        public int LogId { get; set; }
        public int AdminID { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int QuantityExported { get; set; }
        public int OldQuantity { get; set; }
        public int NewQuantity { get; set; }
        public decimal UnitPrice { get; set; }
        public int? OrderId { get; set; }
        public string Address { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}

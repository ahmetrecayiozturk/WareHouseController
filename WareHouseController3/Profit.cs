using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouseController3
{
    public class Profit
    {
        public int Id { get; set; }
        public String ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal PurchasePrice { get; set; }
        public String CustomerName { get; set; }
        public DateTime PaidDate { get; set; }
       // public int Quantity { get; set; }
        //public decimal TotalPrice { get; set; }
        public decimal PaidAmount { get; set; }
    }
}

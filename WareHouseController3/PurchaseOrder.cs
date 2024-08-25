using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouseController3
{
    public class PurchaseOrder
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string SupplierName { get; set; }
        public string Address { get; set; }
        public string ContactInfo { get; set; }
        /*
        partial void OnSupplierAddressChanging(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Supplier address cannot be empty.");
            }
        }
        */
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }
        public bool IsPaid { get; set; }
        /*
        public Product Product { get; set; }
        public Supplier Supplier { get; set; }
        */
    }

}

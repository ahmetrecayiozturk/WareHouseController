using System;
using System.Collections.Generic;
using System.Linq;

namespace WareHouseController3
{
    internal class SalesOrderDal : CrudGenerics<SalesOrder>
    {
        // Ödeme durumu kontrolü
        public List<SalesOrder> GetUnpaidOrders()
        {
            using (var context = new WareHouseControlContext())
            {
                return context.SalesOrders.Where(o => !o.IsPaid).ToList();
            }
        }

        // Ödeme işlemi
        public bool MarkAsPaid(int orderId, DateTime paymentDate)
        {
            using (var context = new WareHouseControlContext())
            {
                var order = context.SalesOrders.FirstOrDefault(o => o.Id == orderId);
                if (order != null)
                {
                    order.IsPaid = true;
                    order.OrderDate = paymentDate; // PaymentDate kullanılması önerilir.
                    context.SaveChanges();
                    return true;
                }
                return false;
            }
        }
    }
}

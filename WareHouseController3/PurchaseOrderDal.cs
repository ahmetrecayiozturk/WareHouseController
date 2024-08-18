using System;
using System.Collections.Generic;
using System.Linq;

namespace WareHouseController3
{
    internal class PurchaseOrderDal : CrudGenerics<PurchaseOrder>
    {
        // Ödeme durumu kontrolü
        public List<PurchaseOrder> GetUnpaidOrders()
        {
            using (var context = new WareHouseControlContext())
            {
                return context.PurchaseOrders.Where(o => !o.IsPaid).ToList();
            }
        }

        // Ödeme işlemi
        public bool MarkAsPaid(int orderId, DateTime paymentDate)
        {
            using (var context = new WareHouseControlContext())
            {
                var order = context.PurchaseOrders.FirstOrDefault(o => o.Id == orderId);
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

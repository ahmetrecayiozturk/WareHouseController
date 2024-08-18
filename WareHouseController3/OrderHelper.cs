using System;
using System.Linq;

namespace WareHouseController3
{
    public static class OrderHelper
    {
        internal static bool TryCreatePurchaseOrder(ProductDal productDal, PurchaseOrderDal purchaseOrderDal, string productName, string supplierName, int quantity)
        {
            var product = productDal.GetAll().FirstOrDefault(p => p.Name == productName);
            if (product != null)
            {
                var totalPrice = product.UnitPrice * quantity;
                var purchaseOrder = new PurchaseOrder
                {
                    ProductName = productName,
                    SupplierName = supplierName,
                    Quantity = quantity,
                    TotalPrice = totalPrice,
                    OrderDate = DateTime.Now,
                    IsPaid = false
                };
                purchaseOrderDal.Add(purchaseOrder);
                return true;
            }
            return false;
        }

        internal static bool TryCreateSalesOrder(ProductDal productDal, SalesOrderDal salesOrderDal, string productName, string customerName, int quantity, out Product updatedProduct)
        {
            var product = productDal.GetAll().FirstOrDefault(p => p.Name == productName);
            if (product != null && product.StockAmount >= quantity)
            {
                var totalPrice = product.UnitPrice * quantity;
                var salesOrder = new SalesOrder
                {
                    ProductName = productName,
                    CustomerName = customerName,
                    Quantity = quantity,
                    TotalPrice = totalPrice,
                    OrderDate = DateTime.Now,
                    IsPaid = false
                };
                salesOrderDal.Add(salesOrder);

                // Stok güncellemesi
                product.StockAmount -= quantity;
                productDal.Update(product);

                updatedProduct = product;
                return true;
            }
            updatedProduct = null;
            return false;
        }
    }
}

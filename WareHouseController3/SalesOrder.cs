﻿using System;
using WareHouseController3;

public class SalesOrder
{
    public int Id { get; set; }
    public string ProductName { get; set; }
    public string CustomerName { get; set; }
    public int Quantity { get; set; }
    public decimal TotalPrice { get; set; }
    public DateTime OrderDate { get; set; }
    public bool IsPaid { get; set; }
    /*
    public Product Product { get; set; }
    public Customer Customer { get; set; }
    */
}

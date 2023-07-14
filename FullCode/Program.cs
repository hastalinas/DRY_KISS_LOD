using System;
using System.Collections.Generic;

namespace FullCode;

public class Program
{
    public static void Main()
    {
        Customer customer = new Customer();

        customer.Name = "Mrs. Shanon";
        Order order1 = new Order { OrderNumber = 1, OrderDate = DateTime.Now, TotalAmount = 1000 };
        Order order2 = new Order { OrderNumber = 2, OrderDate = DateTime.Now, TotalAmount = 2000 };

        customer.AddOrder(order1);
        customer.AddOrder(order2);
        
        customer.PrintCustomerDetail();
    }
}
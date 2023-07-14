using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullCode;

public class Customer
{
    public string Name { get; set; }
    public List<Order> orders;

    public Customer()
    { 
        orders = new List<Order>();
    }

    public void AddOrder(Order order)
    {
        orders.Add(order);
    }

    public void PrintCustomerDetail()
    {
        Console.WriteLine("Customer   : " + Name);

        foreach (var order in orders)
        {
            order.PrintOrderDetail();
        }
    }
}

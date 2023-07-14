using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kelompok2;

public class LodCustomer
{
    public string Name { get; set; }
    private List<LodOrder> orders;

    public LodCustomer()
    {
        orders = new List<LodOrder>();
    }

    public void AddOrder(LodOrder order)
    {
        orders.Add(order);
    }

    public void PrintCustomerOrderDetails()
    {
        Console.WriteLine("Customer: " + Name);

        foreach (var order in orders)
        {
            order.PrintOrderDetails();
        }
    }
}

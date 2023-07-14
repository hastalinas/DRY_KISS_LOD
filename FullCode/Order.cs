using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullCode;

public class Order
{
    public int OrderNumber { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal TotalAmount { get; set; }

    public void PrintOrderDetail()
    {
        Console.WriteLine("Order Number : " + OrderNumber);
        Console.WriteLine("Order Date   : " + OrderDate);
        Console.WriteLine("Total Amount : " + TotalAmount);
    }
}

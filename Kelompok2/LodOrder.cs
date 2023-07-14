using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kelompok2;

public class LodOrder
{
    public int OrderNumber { get; set; }
    public decimal TotalAmount { get; set; }

    public void PrintOrderDetails()
    {
        Console.WriteLine("Order Number: " + OrderNumber);
        Console.WriteLine("Total Amount: " + TotalAmount);
    }
}

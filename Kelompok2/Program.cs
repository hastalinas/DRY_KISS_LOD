using System;

namespace Kelompok2;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("...........Don't Repeat Yourself.............");
        BeforeDry();
        Console.WriteLine("======================");
        AfterDry();
        Console.WriteLine();
        Console.WriteLine("...........Keep It Simple, Stupid.............");
        Kiss kiss = new Kiss();
        kiss.Nama = "John";
        kiss.Umur = 20;
        kiss.PrintStudent();
        Console.WriteLine();

        Console.WriteLine("...........Law of Demeter.............");
        LodCustomer customer = new LodCustomer();
        customer.Name = "John Doe";

        LodOrder order1 = new LodOrder { OrderNumber = 1, TotalAmount = 100 };
        LodOrder order2 = new LodOrder { OrderNumber = 2, TotalAmount = 200 };

        customer.AddOrder(order1);
        customer.AddOrder(order2);

        customer.PrintCustomerOrderDetails();


    }

    public static void BeforeDry()
    {
        Dry bef_dry = new Dry();
        bef_dry.CalculatorCircle(4);
        bef_dry.CalculatorRegtangle(2, 3);
    }

    public static void AfterDry()
    {
        Dry af_dry = new Dry();    
        af_dry.DryCalcCircle(4);
        af_dry.DryCalcRectangle(2, 3);
    }



}

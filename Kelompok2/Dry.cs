using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kelompok2;

public class Dry
{
    //================BEFORE USING DRY====================
    public void CalculatorRegtangle(double length, double width)
    {
        double area = length * width;
        double perimeter = 2 * (length + width);
         
        Console.WriteLine("Luas      : " + area);
        Console.WriteLine("Keliling  : " + perimeter);
    }

    public void CalculatorCircle(double radius)
    {

        double area = Math.PI * Math.Pow(radius, 2);
        double circumference = 2 * Math.PI * radius;

        Console.WriteLine("Luas     : " + area);
        Console.WriteLine("Keliling : " + circumference);
    }

    //================AFTER USING DRY====================
    public void DryCalcCircle(double radius)
    {
        double area = Math.PI * Math.Pow(radius, 2);
        double circumference = 2 * Math.PI * radius;

        PrintShapeProperties("Circle ", area, circumference);
    }
    public void DryCalcRectangle(double length, double width)
    {
        double area = length * width;
        double perimeter = 2 * (length + width);

        PrintShapeProperties("Rectangle ", area, perimeter);
    }

    public void PrintShapeProperties(string shapename, double area, double perimeter)
    {
        Console.WriteLine("Bentuk   : " + shapename);
        Console.WriteLine("Luas     : " + area);
        Console.WriteLine("Keliling : " + perimeter);
        Console.WriteLine();
    }




}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kelompok2;

public class Kiss
{
    public string Nama { get; set; }
    public int Umur { get; set; }
    public void PrintStudent()
    {
        Console.WriteLine("Student Detail ");
        Console.WriteLine("Nama : " + Nama);
        Console.WriteLine("Umur : " + Umur);
    }
}

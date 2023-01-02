using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double total;
               /* t1*/;
            Console.WriteLine("Enter speed in miles");
            int m = Convert.ToInt32(Console.ReadLine());
            total = (m * 1.609)/3600;
            //t1 = total / 3600;
            //double km = t1;
            Console.WriteLine("Speed in Kilometer: " + total);
            Console.ReadLine();
        }
    }
}

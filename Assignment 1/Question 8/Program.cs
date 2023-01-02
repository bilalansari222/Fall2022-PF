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
            Console.WriteLine("Enter Numbers Of Rows:");
            int r = Convert.ToInt32(Console.ReadLine());
            int a, b;
            for (a = 1; a <= r; a++)
            {
                for (b = 1; b <= a; b++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}

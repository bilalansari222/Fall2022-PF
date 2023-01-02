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
            char g;
            Console.WriteLine("Choose between male of female");
            g = Convert.ToChar(Console.ReadLine());

            switch (g)
            {
                case 'M':
                    Console.WriteLine("Age is:");
                    int m = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(" Distance is:");
                    int d = Convert.ToInt32(Console.ReadLine());
                    if (m > 0)
                    {
                        Console.WriteLine(" Valid Number ");
                    }
                    else
                    {
                        Console.WriteLine(" Invalid Number ");
                    }
                    if (m >= 18)
                    {
                        int fare = 10 + (3 * m);
                        Console.WriteLine("The fare is " + fare);
                    }
                    else
                    {
                        int fare = 5 + (3 * m);
                        Console.WriteLine("The fare is " + fare);
                    }
                    break;
                case 'F':
                    Console.WriteLine("Age is:");
                    int f = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(" Distance is:");
                    int d1 = Convert.ToInt32(Console.ReadLine());
                    if (f >= 16)
                    {
                        int fare = 5 + (3 * d1);
                        Console.WriteLine("The fare is " + fare);
                    }
                    else
                    {
                        int fare = 10 + (3 * d1);
                        Console.WriteLine("The fare is " + fare);
                    }
                    break;
            }
            Console.ReadKey();
        }
    }
}

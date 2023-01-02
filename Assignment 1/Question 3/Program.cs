using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
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
                    if (m >= 18)
                    {
                        Console.WriteLine(" The male is : Adult ");
                    }
                    else
                    {
                        Console.WriteLine(" The male is a : Minor ");
                    }
                    break;
                case 'F':
                    Console.WriteLine("Age is:");
                    int f = Convert.ToInt32(Console.ReadLine());
                    if (f >= 16)
                    {
                        Console.WriteLine(" The female is : Adult ");
                    }
                    else
                    {
                        Console.WriteLine(" The female is a : Minor ");
                    }
                    break;
            }
            Console.ReadKey();
        }
    }
}

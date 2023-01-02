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
            Console.WriteLine(" Enter a number :");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number < 0)
            {
                Console.WriteLine("Invalid Input");
            }
            else if (number % 2 != 0)
            {
                Console.WriteLine(" The given number is odd.");
            }
            else
            {
                Console.WriteLine(" The given number is even.");
            }
            Console.ReadKey();
        }
    }
}

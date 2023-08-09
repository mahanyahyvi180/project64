using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp64
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter a Color:");

            string color = Console.ReadLine();

            Console.Write("enter a plural nun:");
               string plural   = Console.ReadLine();

            Console.Write("enter a celebrity :");
            string celebrity = Console.ReadLine();


            Console.WriteLine("roses are" + color);
            Console.WriteLine(plural + "are blue");
            Console.WriteLine("Ilove" + celebrity);

            Console.ReadLine();


        }
    }
}

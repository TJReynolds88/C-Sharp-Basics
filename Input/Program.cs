using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asking Users Name
            Console.Title = "Input";
            Console.Write("Please Enter Your Name.");
            string name = Console.ReadLine();

            // Printing Users Input
            Console.WriteLine("Welcome " + name + "!");
            Console.WriteLine("Hope you enjoy coding in C#");
            Console.ReadKey();

        }
    }
}

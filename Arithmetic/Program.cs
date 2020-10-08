using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int a = 8;
            int b = 4;
            int c = 2;

            Console.WriteLine("Addition: " + (a + b));
            Console.WriteLine("Subtraction: " + (a - b));
            Console.WriteLine("Subtraction backwards: " + ( b - a));
            Console.WriteLine("Multiplication:\t " + (a * b));
            Console.WriteLine("Division:\t " + ( a/b));
            Console.WriteLine("MOdulus:\t " + (a % b));

            //Postfix

            Console.WriteLine("\nPostfix:\t" + (a++)); // Adds one to the variable
            Console.WriteLine("Postfix Result...\t:" + a);

            //PreFix
            Console.WriteLine("\nPrefix:\t" + (++b)); // Adds one to the variable subsequently
            Console.WriteLine("Prefix Result...\t:" + b);

            //
            Console.WriteLine((a + b + c)); // 9 + 5 + 2 = 16
            Console.WriteLine((a * c) + b); // (9 * 2) + 5 = 23
            Console.ReadKey();


        }
    }
}

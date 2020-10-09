using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copied
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Copied";

            string car1 = "Chevy";
            string car2 = "Ford";

            Console.WriteLine("Original");
            Console.WriteLine("\tCar1:" + car1 + " \tCar2: " + car2);

            car1 = String.Copy(car2);
            Console.WriteLine("\nCopied");
            Console.WriteLine("\tCar1:" + car1 + " \tCar2: " + car2);

            int num = car1.Length;
            char[] model = new char [ num ];


            car1.CopyTo(0, model, 0, num);
            Console.WriteLine("\nCharacter Array: ");
            foreach (char c in model)
            {
                Console.Write(c + " ");
            }

            car1 = car1.Remove( 2 );
            Console.WriteLine("\n\nRemoved... \tCar:1 " + car1);

            car1 = car1.Insert(0, "Chrysler");
            car1 = car1.Insert(7, "Dodge");
            Console.WriteLine("\ninserted... :\tCar 1: " + car1);

            car1 = car1.Replace("Tesla", "Riveria");
            Console.WriteLine("\nReplaced... \tCar1: " + car1);
            Console.ReadKey();






        }
    }
}

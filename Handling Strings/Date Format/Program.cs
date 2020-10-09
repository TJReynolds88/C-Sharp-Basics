using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Date Format";

            DateTime now = DateTime.Now;
            Console.Write("Current Date and Time " + now);


            Console.Write("\nDay Name: " + now.DayOfWeek);
            Console.Write("\nDate Only: " + now.ToShortDateString());
            Console.Write("\nTime Only: " + now.ToShortTimeString());

            // Four Years from now
            now = now.AddYears(4);
            Console.Write("\n\nFuture Date: " + now);

            //Create a date and time

            DateTime dt = new DateTime(1988, 12, 31, 22, 00, 00);
            Console.Write("\n\nSet Date and Time: {0:f}", dt);

            Console.Write("\nDay Name: {0:dddd}", dt);
            Console.Write("\nLong Date: {0:D}", dt);
            Console.Write("\nLong Time: {0:T}", dt);
            Console.ReadKey();

        }
    }
}

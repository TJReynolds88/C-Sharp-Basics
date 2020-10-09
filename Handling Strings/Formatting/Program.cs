using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Format
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Format";

            int sum = 3500;
            Console.WriteLine("Currency String: " + sum.ToString("C"));


            //String Format 3500 differnt ways
            Console.Write(String.Format("\nGeneral:\t{0:G}", sum));
            Console.Write(String.Format("\nFixed Point:\t{0:F}", sum));
            Console.Write(String.Format("\nNumber:\t{0:N}", sum));
            Console.Write(String.Format("\nCurrency:\t{0:C}", sum));



            sum /= 1000;
            Console.Write(String.Format("\nPercentage:\t{0:P}", sum));
            Console.Write(String.Format("\nZero Padding:\t{0:00.00000\n}", sum));


            string data = "cody,TJ,Josh,Kyla";
            string[] items = data.Split(',');
            foreach (string item in items)
            {
                Console.Write(String.Format("\n* {0}", item));
            }
            Console.ReadKey();

       

        }
    }
}

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Overload";
            double num;
            double area;

            Console.WriteLine("Please Enter Dimension in Feet: ");
            num = Convert.ToDouble(Console.ReadLine());

            area = computeArea(num);
            Console.WriteLine("\nCircle:\t\tArea = " + area + " sq.ft.");

            area = computeArea(num , num);
            Console.WriteLine("\nSquare:\t\tArea = " + area + " sq.ft.");

            area = computeArea(num , num ,'T');
            Console.WriteLine("\nTriangle:\tArea = " + area + " sq.ft.");
            Console.ReadKey();
        }

        static double computeArea(double width)
        {
            double radius = width / 2;
            return ((radius * radius) * 3.141593);
        }

        static double computeArea(double width, double height)
        {
            return (width * height);
        }
        static double computeArea( double width, double height, char letter)
        {
            return ((width / 2) * height);
        }
        
    }
}

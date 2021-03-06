﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Refactor";
            computeFactorials(1, 8);
            Console.ReadKey();

        }

        static int factorial(int num)
        {
            return (num == 1) ? 1 : (factorial(num - 1) * num);

        }
        static void computeFactorials( int num, int max)
        {
            while(num <= max)
            {
                Console.Write("Factorial Of " + num + " : ");
                Console.WriteLine(factorial(num));
                num++ ;
            }
        }
    }
}

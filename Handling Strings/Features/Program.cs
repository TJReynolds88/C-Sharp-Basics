﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Features";
            Console.Write("Please Enter Text ");
            string text = Console.ReadLine();

            if( String.IsNullOrWhiteSpace(text))
            {
                Console.WriteLine("\nERROR: No Text Found!");
            }
            else
            {
                Console.WriteLine("\nThanks. You Entered: \n" + text + " ");
                Console.WriteLine("\nText Length: " + text.Length);

                string query = text.StartsWith("C#") ? "Does" : "Does Not";
                Console.WriteLine("Text " + query + "Start with 'C#'");

                query = text.EndsWith("steps") ? "Does" : "Does Not";
                Console.WriteLine("Text " + query + "Contain 'easy'");
            }
            Console.ReadKey();
        }
    }
}

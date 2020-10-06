using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manipulate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Manipulate";

            //Request User Input
            Console.Write("Please Enter Text: ");
            string text = Console.ReadLine();

            //Display user input
            Console.Write("\nThanks. You Entered:\n" + text + "");
            Console.WriteLine("\t\tText Length: " + text.Length);

            // Remove leading and trailing white space and report length;
            text = text.Trim();
            Console.Write("\nTrimmed:\t " + text + "");
            Console.WriteLine("\tText Length: " + text.Length);

            string upper = text.ToUpper();
            Console.WriteLine("\nUpperCase: " + upper + "");

            string lower = text.ToLower();
            Console.WriteLine("\nLowerCase: " + lower + " ");

            //Add White Space
            upper = upper.PadLeft(40);
            lower = lower.PadRight(40, '#');
            text = text.PadLeft(30, '*').PadRight(40, '*');

             
            Console.WriteLine("\nPadding Left:\t " + upper + "");
            Console.WriteLine("Padding Right:\t " + lower + "");
            Console.WriteLine("Padded Both:\t " + text + "");

            //Trimmed Versions
            Console.WriteLine("\nTrimmed Start:\t " + upper.TrimStart() + " ");

            Console.WriteLine("\nTrimmed End:\t " + text.TrimEnd('*') + "");
            Console.ReadLine();

        }
    }
}

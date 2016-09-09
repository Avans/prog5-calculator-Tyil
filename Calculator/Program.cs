using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            AgeCalculator c = new AgeCalculator();
            DateTime dt;

            while (true)
            {
                try
                {
                    Console.WriteLine("Enter a valid date: ");
                    string input = Console.ReadLine();

                    if (c.ParseInput(input, out dt)) {
                        break;
                    }
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Incorrect date format. Use dd-mm-yyyy and a VALID date.");
                }
            }

            Console.WriteLine("You are {0} years old!", c.CalculateAge(dt));

            // let's not close the console immediatly
            Console.ReadLine();
        }

    }
}

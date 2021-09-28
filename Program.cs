using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Enables the FizzBuzz replacement if parameter is in args (pass -all for all enabled)
            // If no parameter passed, defaults to all enabled
            // Can enter any other paremeter - eg. none to disable all
            bool fizzEnabled = args.Contains("-fizz") || args.Contains("-all") || args.Length == 0;
            bool buzzEnabled = args.Contains("-buzz") || args.Contains("-all") || args.Length == 0;
            bool bangEnabled = args.Contains("-bang") || args.Contains("-all") || args.Length == 0;
            bool bongEnabled = args.Contains("-bong") || args.Contains("-all") || args.Length == 0;
            bool fezzEnabled = args.Contains("-fezz") || args.Contains("-all") || args.Length == 0;
            bool reverseEnabled = args.Contains("-reverse") || args.Contains("-all") || args.Length == 0;

            Console.WriteLine("Please enter a number to FizzBuzz up to: ");
            int maximumFizzBuzz = Convert.ToInt32(Console.ReadLine());
                
            for (int i = 1; i <= maximumFizzBuzz; i++)
            {
                //FizzBuzz calculations
                bool fizz = (i % 3 == 0);
                bool buzz = (i % 5 == 0);
                bool bang = (i % 7 == 0);
                bool bong = (i % 11 == 0);
                bool fezz = (i % 13 == 0);
                bool reverse = (i % 17 == 0);

                List<string> fizzBuzzList = new List<string>(); // Initialise list

                if ((fezz && !fizz) && fezzEnabled) // Catches case where fezz would be before fizz
                {
                    fizzBuzzList.Add("Fezz");
                }

                if (bong && bongEnabled)
                {
                    fizzBuzzList.Add("Bong");
                }
                
                else if (fizz && fizzEnabled)
                {
                    fizzBuzzList.Add("Fizz");
                    if (fezz && fezzEnabled) // Writes fezz after fizz
                    {
                        fizzBuzzList.Add("Fezz");
                    }
                }

                if (buzz && buzzEnabled)
                {
                    fizzBuzzList.Add("Buzz");
                }

                if (bang && bangEnabled)
                {
                    fizzBuzzList.Add("Bang");
                }

                if (!((fizz && fizzEnabled) || (buzz && buzzEnabled) || (bang && bangEnabled) 
                      || (bong && bongEnabled) || (fezz && fezzEnabled)))
                {
                    fizzBuzzList.Add(i.ToString());
                }

                if (reverse && reverseEnabled)
                {
                    fizzBuzzList.Reverse();
                }

                string joinedList = string.Join("", fizzBuzzList);
                Console.WriteLine(joinedList);
            }
        }
    }
}
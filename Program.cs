using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number to FizzBuzz up to: ");
            int maximumFizzBuzz = Convert.ToInt32(Console.ReadLine());
                
            for (int i = 1; i <= maximumFizzBuzz; i++)
            {
                bool fizz = (i % 3 == 0);
                bool buzz = (i % 5 == 0);
                bool bang = (i % 7 == 0);
                bool bong = (i % 11 == 0);
                bool fezz = (i % 13 == 0);
                bool reverse = (i % 17 == 0);

                List<string> fizzBuzzList = new List<string>();

                if (fezz && !fizz) // Catches case where fezz would be before fizz
                {
                    fizzBuzzList.Add("Fezz");
                }

                if (bong)
                {
                    fizzBuzzList.Add("Bong");
                }
                else if (fizz)
                    {
                        fizzBuzzList.Add("Fizz");
                        if (fezz) // Writes fezz after fizz
                        {
                            fizzBuzzList.Add("Fezz");
                        }
                    }

                    if (buzz)
                    {
                        fizzBuzzList.Add("Buzz");
                    }

                    if (bang)
                    {
                        fizzBuzzList.Add("Bang");
                    }

                    if (!(fizz || buzz || bang || bong || fezz))
                    {
                        fizzBuzzList.Add(i.ToString());
                    }
                

                if (reverse)
                {
                    fizzBuzzList.Reverse();
                }

                string joinedList = string.Join("", fizzBuzzList);
                Console.WriteLine(joinedList);
            }
        }
    }
}
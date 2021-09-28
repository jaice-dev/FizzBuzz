using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 200; i++)
            {
                bool fizz = (i % 3 == 0);
                bool buzz = (i % 5 == 0);
                bool bang = (i % 7 == 0);
                bool bong = (i % 11 == 0);
                bool fezz = (i % 13 == 0);
                bool reverse = (i % 17 == 0);

                List<string> output = new List<string>();

                if (fezz && !fizz) // Catches case where fezz would be before fizz
                {
                    output.Add("Fezz");
                }
                if (bong)
                {
                    output.Add("Bong");
                }
                else
                {
                    if (fizz)
                    {
                        Console.Write("Fizz");
                        if (fezz) // Writes fezz after fizz
                        {
                            output.Add("Fezz");
                        }
                    }
                    if (buzz)
                    {
                        output.Add("Buzz");
                    }

                    if (bang)
                    {
                        output.Add("Bang");
                    }
                    if (!(fizz || buzz || bang || bong || fezz))
                    {
                        output.Add(i.ToString());
                    }
                }
                output.ForEach(Console.Write);
                Console.Write("\n");
            }
        }
    }
}
using System;

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

                if (fezz && !fizz) // Catches case where fezz would be before fizz
                {
                    Console.Write("Fezz");
                }
                if (bong)
                {
                    Console.Write("Bong");
                }
                else
                {
                    if (fizz)
                    {
                        Console.Write("Fizz");
                        if (fezz) // Writes fezz after fizz
                        {
                            Console.Write("Fezz");
                        }
                    }
                    if (buzz)
                    {
                        Console.Write("Buzz");
                    }

                    if (bang)
                    {
                        Console.Write("Bang");
                    }
                    if (!(fizz || buzz || bang || bong || fezz))
                    {
                        Console.Write(i);
                    }
                }
                Console.Write("\n");
            }
        }
    }
}
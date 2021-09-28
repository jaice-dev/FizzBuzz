using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                bool fizz = (i % 3 == 0);
                bool buzz = (i % 5 == 0);
                bool bang = (i % 7 == 0);
                bool bong = (i % 11 == 0);

                if (bong)
                {
                    Console.Write("Bong");
                }
                else
                {
                    if (fizz)
                    {
                        Console.Write("Fizz");
                    }
                    if (buzz)
                    {
                        Console.Write("Buzz");
                    }

                    if (bang)
                    {
                        Console.Write("Bang");
                    }
                    if (!(fizz || buzz || bang))
                    {
                        Console.Write(i);
                    }
                }
                Console.Write("\n");
            }
        }
    }
}
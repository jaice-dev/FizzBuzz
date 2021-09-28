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
                
                if (fizz)
                {
                    Console.Write("Fizz");
                }
                if (buzz)
                {
                    Console.Write("Buzz");
                }
                if (!(fizz || buzz))
                {
                    Console.Write(i);
                }
                
                Console.Write("\n");
            }
        }
    }
}
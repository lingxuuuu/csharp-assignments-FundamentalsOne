using System;

namespace FundamentalsOne
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 256; i++)
            {
                Console.WriteLine(i);
            }

            for (int i = 1; i < 101; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    continue;
                }
                else if (i % 3 == 0 || i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            for (int i = 1; i < 101; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine(i + " FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine(i + " Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine(i + " Buzz");
                }
            }

        }
    }
}


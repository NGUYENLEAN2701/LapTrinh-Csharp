using System;

namespace if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 33;

            if (x == 8)
            {
                Console.WriteLine("Value of x is 8");
            }
            else if (x == 18)
            {
                Console.WriteLine("Value of x is 18");
            }
            else if (x == 33)
            {
                Console.WriteLine("Value of x is 33");
            }
            else
            {
                Console.WriteLine("No match");
            }

        }
    }
}

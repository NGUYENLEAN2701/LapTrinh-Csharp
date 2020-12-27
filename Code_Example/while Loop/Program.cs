using System;

namespace while_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            while (x++ < 5)
            {
                if (x % 2 == 0)
                    x += 2;
                Console.WriteLine("*");
            }
        }
    }
}

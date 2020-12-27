using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 1; x < 8; x++)
            {
                if (x > 5)
                    break;
                Console.WriteLine(x);
            }
        }
    }
}

using System;

namespace for_loop
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 1;
            for (; x < 7;)
            {
                x += 2;
                Console.WriteLine("Hello World!");
            }
            int a = 0;
            do
            {
                Console.WriteLine(a);
                a++;
            } while (a < 5);
        }
    }
}

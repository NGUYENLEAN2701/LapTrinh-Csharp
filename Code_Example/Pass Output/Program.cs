using System;

namespace Pass_Output
{
    class Program
    {
        static void GetValues(out int x, out int y)
        {
            x = 5;
            y = 42;
        }
        static void Main(string[] args)
        {
            int a, b;
            GetValues(out a, out b);
            Console.WriteLine(a + " " + b);
        }
    }
}

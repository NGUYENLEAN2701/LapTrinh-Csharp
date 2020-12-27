using System;

namespace Test
{
    class Program
    {
        static void Test(int x)
        {
            x = 8;
        }
        static void Main()
        {
            int a = 5;
            Test(a);
            Console.WriteLine(a);
        }
    }
}

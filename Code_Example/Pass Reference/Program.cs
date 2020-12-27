using System;

namespace Pass_Reference
{
    class Program
    {
        static void Swap(ref int x, ref int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
        }
        static void Sqr(ref int x)
        {
            x = x * x;
        }
        static void Main(string[] args)
        {
            int a = 3;
            Sqr(ref a);
            Console.WriteLine(a);
            int x = 1, y = 0;
            Console.WriteLine("x = {0}, y = {1}", x, y);
            Swap(ref x, ref y);
            Console.WriteLine("x = {0}, y = {1}", x, y);
        }
    }
}

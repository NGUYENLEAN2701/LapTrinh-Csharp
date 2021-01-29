using System;
using System.Collections.Generic;
namespace _55_fibonacci
{
    class Program
    {
        static ulong fibonacci(int n)
        {
            if (n == 1 || n == 2) return 1;
            return fibonacci(n - 1) + fibonacci(n - 2);
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write(fibonacci(n));
        }
    }
}

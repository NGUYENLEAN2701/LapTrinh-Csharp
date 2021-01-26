using System;

namespace _52_giai_thừa
{
    class Program
    {
        static ulong giaithua(ulong n)
        {
            if (n == 0) return 1;
            else return n * giaithua(n - 1);
        }
        static void Main(string[] args)
        {
            ulong n = Convert.ToUInt64(Console.ReadLine());
            Console.Write(giaithua(n));
        }
    }
}

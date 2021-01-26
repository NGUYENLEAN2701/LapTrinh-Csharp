using System;

namespace _53_tính_mũ
{
    class Program
    {
        static ulong luythua(ulong a, ulong b)
        {
            if (b == 0) return 1;
            else return a * luythua(a, b - 1);
        }
        static void Main(string[] args)
        {
            ulong a = Convert.ToUInt64(Console.ReadLine());
            ulong b = Convert.ToUInt64(Console.ReadLine());
            Console.Write(luythua(a, b));
        }
    }
}

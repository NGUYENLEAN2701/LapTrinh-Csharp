using System;

namespace _54_ước_chung_lớn_nhất
{
    class Program
    {
        static int UCLN(int a, int b)
        {
            return (b == 0) ? a : UCLN(b, a % b);
        }
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write(UCLN(a, b));
        }
    }
}

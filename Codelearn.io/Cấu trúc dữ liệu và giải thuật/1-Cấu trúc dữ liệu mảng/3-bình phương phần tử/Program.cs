using System;

namespace _3_bình_phương_phần_tử
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int k in a)
                Console.Write("{0} ", k * k);
        }
    }
}

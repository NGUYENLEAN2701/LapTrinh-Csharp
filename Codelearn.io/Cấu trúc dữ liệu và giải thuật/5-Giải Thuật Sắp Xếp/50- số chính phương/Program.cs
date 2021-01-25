using System;
using System.Collections.Generic;
namespace _50__số_chính_phương
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            List<int> a = new List<int>();
            for (int i = 0; i < n; i++)
                a.Add(Convert.ToInt32(Console.ReadLine()));
            a.Sort();
            int count = 0;
            int sqrt = (int)Math.Sqrt(a[0]);
            if (sqrt * sqrt == a[0])
            {
                count++;
                Console.Write("{0} ", a[0]);
            }
            for (int i = 1; i < n; i++)
            {
                sqrt = (int)Math.Sqrt(a[i]);
                if (sqrt * sqrt == a[i] && a[i] != a[i - 1])
                {
                    count++;
                    Console.Write("{0} ", a[i]);
                }
            }
            if (count == 0) Console.Write("NULL");
        }
    }
}

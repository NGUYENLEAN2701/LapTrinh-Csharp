using System;
using System.Collections.Generic;
namespace _60_chuỗi_tổ_hợp
{
    class Program
    {
        static List<int> x = new List<int>();
        static void printList(List<int> a, int n)
        {
            for (int i = 1; i <= n; i++)
                Console.Write("{0}", a[i]);
            Console.Write(" ");
        }
        static void hoantohop(int h, int k, int n)
        {
            for (int i = x[h - 1] + 1; i <= n - (k - h); i++)
            {
                x[h] = i;
                if (h == k) printList(x, k);
                else
                {
                    hoantohop(h + 1, k, n);
                }
            }
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int k = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                x.Add(i);
            }
            hoantohop(1, k, n);
        }
    }
}


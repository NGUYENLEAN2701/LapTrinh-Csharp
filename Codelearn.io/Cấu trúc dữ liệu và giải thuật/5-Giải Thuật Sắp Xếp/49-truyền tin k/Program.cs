using System;
using System.Collections.Generic;
namespace _49_truyền_tin_k
{
    class Program
    {
        static int result(List<int> a, int n, int k)
        {
            int count = 0;
            for (int i = 1; i < n; i++)
            {
                if (a[i] - a[i - 1] > k)
                {
                    count++;
                }
            }
            return count + 1;
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            List<int> a = new List<int>();
            for (int i = 0; i < n; i++)
                a.Add(Convert.ToInt32(Console.ReadLine()));
            int k = Convert.ToInt32(Console.ReadLine());
            a.Sort();
            Console.Write(result(a, n, k));
        }
    }
}

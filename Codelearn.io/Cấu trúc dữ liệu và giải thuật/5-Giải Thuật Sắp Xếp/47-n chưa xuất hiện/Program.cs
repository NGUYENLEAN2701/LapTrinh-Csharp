using System;
using System.Collections.Generic;
namespace _47_n_chưa_xuất_hiện
{
    class Program
    {
        static int solve(List<int> a, int n)
        {
            List<int> b = new List<int>(a);//nên copy sang dãy khác để ko làm thay đổi dãy a
            b.Sort();
            if (b[0] > 0) return 0;
            for (int i = 1; i < n; i++)
            {
                if (b[i] - b[i - 1] > 1)
                {
                    return b[i - 1] + 1;
                }
            }
            return b[n - 1] + 1;
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            List<int> a = new List<int>();
            for (int i = 0; i < n; i++)
                a.Add(Convert.ToInt32(Console.ReadLine()));
            Console.Write(solve(a, n));
        }
    }
}

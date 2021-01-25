using System;
using System.Collections.Generic;
namespace _51_bài_tập_sắp_xếp
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            List<int> a = new List<int>();
            for (int i = 0; i < n; i++)
                a.Add(Convert.ToInt32(Console.ReadLine()));
            List<int> b = new List<int>(); ;
            foreach (int item in a)
            {
                if (item != 0) b.Add(item);
            }
            b.Sort();
            int k = 0;
            for (int i = n - 1; i >= 0; i--)
            {
                if (a[i] < 0)
                {
                    a[i] = b[k];
                    k++;
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (a[i] > 0)
                {
                    a[i] = b[k];
                    k++;
                }
            }
            foreach (int item in a)
                Console.Write("{0} ", item);
        }
    }
}

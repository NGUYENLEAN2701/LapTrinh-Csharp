using System;
using System.Collections.Generic;
namespace _10_tổng_phần_tử_mảng_2_chiều
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            List<List<int>> a = new List<List<int>>();
            for (int i = 0; i < m; i++)
            {
                a.Add(new List<int>());
                for (int j = 0; j < n; j++)
                {
                    a[i].Add(Convert.ToInt32(Console.ReadLine()));
                }
            }
            int count = 0;
            // foreach (List<int> sublist in a)
            // {
            //     foreach (int item in sublist)
            //         Console.Write("{0} ", item);
            //     Console.WriteLine();
            // }
            foreach (List<int> sublist in a)
                foreach (int item in sublist)
                    count += item;
            Console.WriteLine(count);
        }
    }
}

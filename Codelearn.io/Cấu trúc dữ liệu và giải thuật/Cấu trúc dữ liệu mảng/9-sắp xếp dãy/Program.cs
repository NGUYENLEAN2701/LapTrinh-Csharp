using System;
using System.Collections.Generic;
namespace _9_sắp_xếp_dãy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            List<int> a = new List<int>();
            for (int i = 0; i < n; i++)
            {
                a.Add(Convert.ToInt32(Console.ReadLine()));
            }
            int m = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                a.Add(Convert.ToInt32(Console.ReadLine()));
            }
            a.Sort();
            foreach (int item in a)
                Console.Write("{0} ", item);
        }
    }
}

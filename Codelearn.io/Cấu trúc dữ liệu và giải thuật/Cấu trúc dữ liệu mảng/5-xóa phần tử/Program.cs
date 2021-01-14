using System;
using System.Collections.Generic;
namespace _5_xóa_phần_tử
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
            foreach (int item in a)
                Console.Write("{0} ", item);
        }
    }
}

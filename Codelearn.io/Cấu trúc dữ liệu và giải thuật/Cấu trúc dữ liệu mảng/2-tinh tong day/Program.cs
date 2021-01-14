using System;
using System.Collections.Generic;
namespace _2_tinh_tong_day
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
            int Sum_of_Arr = 0;
            foreach (int item in a)
            {
                Sum_of_Arr += item;
            }
            Console.WriteLine(Sum_of_Arr);
        }
    }
}

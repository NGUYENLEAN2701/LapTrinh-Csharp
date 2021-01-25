using System;
using System.Collections.Generic;
namespace _38b_tìm_kiếm_mặc_định
{
    class Program
    {
        static void Main(string[] args)
        {
            int n_size = Convert.ToInt32(Console.ReadLine());
            List<int> list = new List<int>();
            for (int i = 0; i < n_size; i++)
                list.Add(Convert.ToInt32(Console.ReadLine()));
            int value = Convert.ToInt32(Console.ReadLine());
            Console.Write(list.IndexOf(value));
        }
    }
}

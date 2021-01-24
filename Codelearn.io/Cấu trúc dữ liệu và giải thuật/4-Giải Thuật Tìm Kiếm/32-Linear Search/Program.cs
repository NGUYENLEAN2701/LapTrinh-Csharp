using System;
using System.Collections.Generic;
namespace _32_Linear_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            int n_size = Convert.ToInt32(Console.ReadLine());
            List<int> list = new List<int>();
            for (int i = 0; i < n_size; i++)
                list.Add(Convert.ToInt32(Console.ReadLine()));
            int x_value = Convert.ToInt32(Console.ReadLine());
            int k_index = -1;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == x_value)
                {
                    k_index = i;
                    break;
                }
            }
            Console.Write(k_index);
        }
    }
}

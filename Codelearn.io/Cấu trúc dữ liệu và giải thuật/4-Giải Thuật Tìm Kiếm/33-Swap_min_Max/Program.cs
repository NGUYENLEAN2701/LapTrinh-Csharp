using System;
using System.Collections.Generic;
namespace _33_Swap_min_Max
{
    class Program
    {
        static void Main(string[] args)
        {
            int n_size = Convert.ToInt32(Console.ReadLine());
            List<int> list = new List<int>();
            for (int i = 0; i < n_size; i++)
                list.Add(Convert.ToInt32(Console.ReadLine()));
            int min_index = 0;
            int max_index = 0;
            for (int i = 0; i < n_size; i++)
            {
                if (list[i] < list[min_index]) min_index = i;
                if (list[i] >= list[max_index]) max_index = i;
            }
            int temp = list[min_index];
            list[min_index] = list[max_index];
            list[max_index] = temp;
            foreach (int item in list)
                Console.Write("{0} ", item);

        }
    }
}

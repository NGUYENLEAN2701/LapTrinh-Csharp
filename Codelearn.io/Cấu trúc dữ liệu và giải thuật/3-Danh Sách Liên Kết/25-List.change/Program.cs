using System;
using System.Collections.Generic;
namespace _25_List.change
{
    class Program
    {
        static void Main(string[] args)
        {
            int n_size = Convert.ToInt32(Console.ReadLine());
            List<int> L = new List<int>();
            for (int i = 0; i < n_size; i++)
                L.Add(Convert.ToInt32(Console.ReadLine()));
            int k_value = Convert.ToInt32(Console.ReadLine());
            int c_value = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < L.Count; i++)
            {
                if (L[i] == k_value) L[i] = c_value;
                Console.Write("{0} ", L[i]);
            }
        }
    }
}

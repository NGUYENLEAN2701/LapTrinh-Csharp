using System;
using System.Collections.Generic;
namespace _22_List.Insert
{
    class Program
    {
        static void Main(string[] args)
        {
            int n_size = Convert.ToInt32(Console.ReadLine());
            List<int> L = new List<int>();
            for (int i = 0; i < n_size; i++)
                L.Add(Convert.ToInt32(Console.ReadLine()));
            int k_location = Convert.ToInt32(Console.ReadLine());
            int k_value = Convert.ToInt32(Console.ReadLine());
            L.Insert(k_location, k_value);
            foreach (int item in L)
                Console.Write("{0} ", item);
        }
    }
}

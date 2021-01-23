using System;
using System.Collections.Generic;
namespace _21_List_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int n_size = Convert.ToInt32(Console.ReadLine());
            List<int> L = new List<int>();
            for (int i = 0; i < n_size; i++)
                L.Add(Convert.ToInt32(Console.ReadLine()));
            foreach (int item in L)
                Console.Write("{0} ", item);
        }
    }
}

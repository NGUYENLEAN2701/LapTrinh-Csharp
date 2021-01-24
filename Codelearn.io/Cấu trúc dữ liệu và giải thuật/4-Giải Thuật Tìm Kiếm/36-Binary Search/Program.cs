using System;
using System.Collections.Generic;
namespace _36_Binary_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            int n_size = Convert.ToInt32(Console.ReadLine());
            List<int> list = new List<int>();
            for (int i = 0; i < n_size; i++)
                list.Add(Convert.ToInt32(Console.ReadLine()));
            list.Sort();
            int value = Convert.ToInt32(Console.ReadLine());

        }
    }
}

using System;
using System.Collections.Generic;
namespace _34_Count_Value
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
            int value_count = 0;
            foreach (int item in list)
                if (item == value) value_count++;
            Console.Write(value_count);
        }
    }
}

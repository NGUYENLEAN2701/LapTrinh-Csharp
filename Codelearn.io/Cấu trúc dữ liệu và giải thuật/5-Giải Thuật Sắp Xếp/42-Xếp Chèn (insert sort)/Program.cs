using System;
using System.Collections.Generic;
namespace _42_Xếp_Chèn__insert_sort_
{
    class Program
    {
        static void insertionSort(List<int> a, int n)
        {
            int index, value;
            for (int i = 1; i < n; i++)
            {
                index = i;
                value = a[i];
                while (index > 0 && a[index - 1] > value)
                {
                    a[index] = a[index - 1];
                    index--;
                }
                a[index] = value;
            }
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            List<int> a = new List<int>();
            for (int i = 0; i < n; i++)
                a.Add(Convert.ToInt32(Console.ReadLine()));
            insertionSort(a, n);
            foreach (int item in a)
                Console.Write("{0} ", item);
        }
    }
}

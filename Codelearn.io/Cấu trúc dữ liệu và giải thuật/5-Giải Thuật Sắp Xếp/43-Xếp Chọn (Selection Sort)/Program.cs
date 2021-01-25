using System;
using System.Collections.Generic;
namespace _43_Xếp_Chọn__Selection_Sort_
{
    class Program
    {
        static void selectionSort(List<int> a, int n)
        {
            int indexMin;
            for (int i = 0; i < n - 1; i++)
            {
                indexMin = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (a[indexMin] > a[j])
                    {
                        indexMin = j;
                    }
                }
                if (i != indexMin)
                {
                    int temp = a[i];
                    a[i] = a[indexMin];
                    a[indexMin] = temp;
                }
            }
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            List<int> a = new List<int>();
            for (int i = 0; i < n; i++)
                a.Add(Convert.ToInt32(Console.ReadLine()));
            selectionSort(a, n);
            foreach (int item in a)
                Console.Write("{0} ", item);
        }
    }
}

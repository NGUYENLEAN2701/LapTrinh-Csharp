using System;
using System.Collections.Generic;
namespace _46_quick_sort
{
    class Program
    {
        static void quickSort(List<int> a, int l, int r)
        {
            int p = a[(l + r) / 2];
            int i = l, j = r;
            while (i < j)
            {
                while (a[i] < p)
                {
                    i++;
                }
                while (a[j] > p)
                {
                    j--;
                }
                if (i <= j)
                {
                    int temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                    i++;
                    j--;
                }
            }
            if (i < r)
            {
                quickSort(a, i, r);
            }
            if (l < j)
            {
                quickSort(a, l, j);
            }
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            List<int> a = new List<int>();
            for (int i = 0; i < n; i++)
                a.Add(Convert.ToInt32(Console.ReadLine()));
            quickSort(a, 0, n - 1);
            foreach (int item in a)
                Console.Write("{0} ", item);
        }
    }
}

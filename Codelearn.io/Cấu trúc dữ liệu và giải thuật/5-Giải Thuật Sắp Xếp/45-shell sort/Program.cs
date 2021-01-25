using System;
using System.Collections.Generic;
namespace _45_shell_sort
{
    class Program
    {
        static void shellSort(List<int> a, int n)
        {
            int interval, i, j, temp;
            for (interval = n / 2; interval > 0; interval /= 2)
            {
                for (i = interval; i < n; i++)
                {
                    temp = a[i];
                    for (j = i; j >= interval && a[j - interval] > temp; j -= interval)
                    {
                        a[j] = a[j - interval];
                    }
                    a[j] = temp;
                }
            }
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            List<int> a = new List<int>();
            for (int i = 0; i < n; i++)
                a.Add(Convert.ToInt32(Console.ReadLine()));
            shellSort(a, n);
            foreach (int item in a)
                Console.Write("{0} ", item);
        }
    }
}

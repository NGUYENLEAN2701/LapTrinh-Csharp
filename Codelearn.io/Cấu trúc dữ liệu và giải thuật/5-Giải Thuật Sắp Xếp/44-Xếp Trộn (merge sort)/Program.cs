using System;
using System.Collections.Generic;
namespace _44_Xếp_Trộn__merge_sort_
{
    class Program
    {
        static void merge(List<int> arr, int l, int m, int r)
        {
            int i, j, k;
            int n1 = m - l + 1;
            int n2 = r - m;
            int[] L = new int[n1];
            int[] R = new int[n2];
            for (i = 0; i < n1; i++)
            {
                L[i] = arr[l + i];
            }
            for (j = 0; j < n2; j++)
            {
                R[j] = arr[m + 1 + j];
            }
            i = 0;
            j = 0;
            k = l;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }
            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }
        static void mergeSort(List<int> a, int l, int r)
        {
            if (l < r)
            {
                int m = l + (r - l) / 2;
                mergeSort(a, l, m);
                mergeSort(a, m + 1, r);
                merge(a, l, m, r);
            }
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            List<int> a = new List<int>();
            for (int i = 0; i < n; i++)
                a.Add(Convert.ToInt32(Console.ReadLine()));
            mergeSort(a, 0, n - 1);
            foreach (int item in a)
                Console.Write("{0} ", item);
        }
    }
}

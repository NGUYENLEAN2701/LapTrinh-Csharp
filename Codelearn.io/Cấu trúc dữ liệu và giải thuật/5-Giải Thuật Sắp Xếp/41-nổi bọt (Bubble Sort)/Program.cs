using System;
using System.Collections.Generic;
namespace _41_nổi_bọt__Bubble_Sort_
{
    class Program
    {
        static void bubbleSort(List<int> a, int n)
        {
            bool swapper = true;
            for (int i = n - 1; i >= 1; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                        swapper = false;
                    }
                }
                if (swapper)
                {
                    break;
                }
            }
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            List<int> a = new List<int>();
            for (int i = 0; i < n; i++)
                a.Add(Convert.ToInt32(Console.ReadLine()));
            bubbleSort(a, n);
            foreach (int item in a)
                Console.Write("{0} ", item);
        }
    }
}

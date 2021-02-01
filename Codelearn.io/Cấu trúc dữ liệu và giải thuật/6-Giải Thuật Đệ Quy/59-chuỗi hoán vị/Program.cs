using System;
using System.Collections.Generic;
namespace _59_chuỗi_hoán_vị
{
    class Program
    {
        static List<bool> b = new List<bool>();
        static List<int> x = new List<int>();
        static void printList(List<int> a, int n)
        {
            for (int i = 1; i <= n; i++)
                Console.Write("{0}", a[i]);
            Console.Write(" ");
        }
        static void hoanvichuoi(int k, int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (b[i])
                {
                    x[k] = i;
                    if (k == n)
                    {
                        printList(x, n);
                    }
                    else
                    {
                        b[i] = false;
                        hoanvichuoi(k + 1, n);
                        b[i] = true;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                b.Add(true);
                x.Add(i);
            }
            hoanvichuoi(1, n);
        }
    }
}

using System;
using System.Collections.Generic;
namespace _48__Tần_số
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            List<int> a = new List<int>();
            for (int i = 0; i < n; i++)
            {
                a.Add(Convert.ToInt32(Console.ReadLine()));
            }
            a.Sort();
            int count = 0;
            int old_item = a[0];
            Console.Write("{0} ", a[0]);
            foreach (int item in a)
            {
                if (item != old_item)
                {
                    Console.Write("{0}; ", count);
                    Console.Write("{0} ", item);
                    count = 1;
                    old_item = item;
                }
                else count++;
            }
            Console.Write("{0}; ", count);
        }
    }
}

using System;
using System.Collections.Generic;
namespace _6_in_số_nguyên_tố
{
    class Program
    {
        static bool Check_Prime(int n)
        {
            if (n < 2) return false;
            else if (n <= 3) return true;
            else if (n % 2 == 0) return false;
            else if (n % 3 == 0) return false;
            else
            {
                int i = 5;
                while (i * i <= n)
                {
                    if (n % i == 0) return false;
                    if (n % (i + 2) == 0) return false;
                    i += 6;
                }
                return true;
            }
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            List<int> a = new List<int>();
            for (int i = 0; i < n; i++)
            {
                a.Add(Convert.ToInt32(Console.ReadLine()));
            }
            foreach (int item in a)
                if (Check_Prime(item))
                    Console.Write("{0} ", item);

        }
    }
}

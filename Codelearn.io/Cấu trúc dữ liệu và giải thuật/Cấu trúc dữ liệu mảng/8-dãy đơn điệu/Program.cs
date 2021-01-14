using System;
using System.Collections.Generic;
namespace _8_dãy_đơn_điệu
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
            bool kt1 = true; // kiểm tra dãy tăng.
            bool kt2 = true; // kiểm tra dãy giảm.
            for (int i = 1; i < n; i++)
            {
                if (a[i] <= a[i - 1]) kt1 = false;
                if (a[i] >= a[i - 1]) kt2 = false;
            }
            if (kt1 || kt2) Console.WriteLine("YES");
            else Console.WriteLine("NO");
        }
    }
}

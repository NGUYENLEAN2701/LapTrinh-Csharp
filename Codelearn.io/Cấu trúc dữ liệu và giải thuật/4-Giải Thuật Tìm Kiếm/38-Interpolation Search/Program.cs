using System;

namespace _38_Interpolation_Search
{
    class Program
    {
        static int interpolationSearch(int[] a, int n, int x)
        {
            int l = 0, r = n - 1;
            while (a[r] != a[l] && x >= a[l] && x <= a[r])
            {
                int mid = l + (r - l) * (x - a[l]) / (a[r] - a[l]);
                if (a[mid] < x)
                {
                    l = mid + 1;
                }
                else if (a[mid] > x)
                {
                    r = mid - 1;
                }
                else
                {
                    if (mid > 0 && a[mid - 1] == x)
                    {
                        r = mid - 1;
                    }
                    else
                    {
                        return mid;
                    }
                }
            }
            if (a[l] == x)
            {
                return l;
            }
            return -1;
        }

        static int[] a = new int[100];
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write(interpolationSearch(a, n, x));
        }
    }
}

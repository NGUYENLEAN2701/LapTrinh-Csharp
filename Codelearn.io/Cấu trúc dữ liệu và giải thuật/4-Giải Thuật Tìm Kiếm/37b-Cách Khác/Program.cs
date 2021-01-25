using System;
namespace _37b_Cách_Khác
{
    class Program
    {
        static int[] a = new int[100001];
        static int[] b = new int[100001];

        static int BinSearch(int[] a, int n, int x)
        {
            int l = 0;
            int r = n - 1;
            while (l < r)
            {
                int mid = (l + r) / 2; ;
                if (a[mid] < x)
                {
                    l = mid + 1;
                }
                else
                {
                    r = mid;
                }
            }
            if (a[l] == x)
            {
                return l;
            }
            return -1;
        }
        static void printArray(int[] a, int n, int l, int r)
        {
            for (int i = l; i <= r; i++)
            {
                Console.Write("{0} ", a[i]);
            }
        }
        static bool solve(int[] a, int[] b, int n, int s)
        {
            b[0] = a[0];
            for (int i = 1; i < n; i++)
            {
                b[i] = b[i - 1] + a[i];
            }
            for (int i = 0; i < n; i++)
            {
                if (b[i] == s)
                {
                    printArray(a, n, 0, i);
                    return true;
                }
                if (b[i] > s)
                {
                    int l = BinSearch(b, n, b[i] - s);
                    if (l != -1)
                    {
                        printArray(a, n, l + 1, i);
                        return true;
                    }
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
                a[i] = Convert.ToInt32(Console.ReadLine());
            int s = Convert.ToInt32(Console.ReadLine());
            bool k = solve(a, b, n, s);
            if (!k)
            {
                Console.Write(-1);
            }
            //Kiểm Thử 4: 80ms
        }
    }
}


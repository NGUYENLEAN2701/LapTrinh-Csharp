using System;

namespace _57_phỏng_đoán_Collatz
{
    class Program
    {
        static int count = 0;
        static void convert(int n, int k)
        {
            if (k == 0)
            {
                count++;
            }
            else
            {
                convert(2 * n, k - 1);
                if ((n - 1) % 3 == 0 && ((n - 1) / 3) % 2 == 1)
                {
                    convert((n - 1) / 3, k - 1);
                }
            }
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int k = Convert.ToInt32(Console.ReadLine());
            convert(n, k);
            Console.Write(count);
        }
    }
}

using System;

namespace _61__bài_tập
{

    class Program
    {
        static int solve(int n)
        {
            if (n == 1) return 1;
            return solve(n / 2) + solve(n - n / 2);
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write(solve(n));
            //n
        }
    }
}

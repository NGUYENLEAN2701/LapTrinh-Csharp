using System;

namespace _56_gameGuessNumber
{
    class Program
    {
        static int gameGuessNumber(ulong n)
        {
            if (n == 1) return 1;
            return 1 + gameGuessNumber(n - (n + 1) / 2);
        }
        static void Main(string[] args)
        {
            ulong n = Convert.ToUInt64(Console.ReadLine());
            Console.Write(gameGuessNumber(n));
        }
    }
}

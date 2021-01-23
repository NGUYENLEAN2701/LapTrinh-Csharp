using System;
using System.Collections.Generic;
namespace _18_số_siêu_nguyên_tố
{
    class Program
    {
        static bool prime_check(int n)
        {
            if (n < 2) return false;
            else if (n <= 3) return true;
            else if (n % 2 == 0 || n % 3 == 0) return false;
            else
            {
                for (int i = 5; i * i <= n; i = i + 6)
                    if (n % i == 0 || n % (i + 2) == 0)
                        return false;
                return true;
            }
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Queue<int> super_primes = new Queue<int>();
            if (n < 2) Console.Write("");
            else if (n == 2) Console.Write(2);
            else if (n <= 7)
            {
                for (int i = 2; i <= n; i += 1)
                    if (prime_check(i)) Console.Write("{0} ", i);
            }
            else
            {
                int[] odd_item = new int[5] { 1, 3, 5, 7, 9 };
                super_primes.Enqueue(2);
                for (int i = 3; i <= 7; i += 2) super_primes.Enqueue(i);
                while (super_primes.Count != 0)
                {
                    foreach (int k in odd_item)
                        if (prime_check(super_primes.Peek() * 10 + k) && (super_primes.Peek() * 10 + k) <= n)
                            super_primes.Enqueue(super_primes.Peek() * 10 + k);
                    Console.Write("{0} ", super_primes.Dequeue());
                }
            }

        }
    }
}

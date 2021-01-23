using System;
using System.Collections.Generic;
namespace Loop_dynamic_List
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
            List<int> super_primes = new List<int>();
            if (n == 2) super_primes.Add(2);
            else if (n <= 7)
            {
                super_primes.Add(2);
                for (int i = 3; i <= n; i += 2)
                    if (prime_check(i)) super_primes.Add(i);
            }
            else
            {
                int[] odd_item = new int[5] { 1, 3, 5, 7, 9 };
                super_primes.Add(2);
                for (int i = 3; i <= 7; i += 2) super_primes.Add(i);
                for (int i = 0; i < super_primes.Count; i++)
                    foreach (int k in odd_item)
                        if (prime_check(super_primes[i] * 10 + k) && (super_primes[i] * 10 + k) <= n)
                            super_primes.Add(super_primes[i] * 10 + k);
            }
            foreach (int item in super_primes)
                Console.Write("{0} ", item);

        }
    }
}

using System;
using System.Collections.Generic;
namespace _17_dịch_chuyển_k_lần
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Queue<int> q = new Queue<int>();
            for (int i = 0; i < n; i++)
            {
                q.Enqueue(Convert.ToInt32(Console.ReadLine()));
            }
            int k = Convert.ToInt32(Console.ReadLine());
            while ((k--) > 0)
            {
                q.Enqueue(q.Dequeue());
            }
            while (q.Count != 0)
                Console.Write("{0} ", q.Dequeue());

        }
    }
}

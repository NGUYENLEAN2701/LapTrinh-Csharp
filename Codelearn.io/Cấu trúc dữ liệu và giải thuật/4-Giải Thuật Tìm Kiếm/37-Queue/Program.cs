using System;
using System.Collections.Generic;
namespace _37_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            int n_size = Convert.ToInt32(Console.ReadLine());
            int[] myArray = new int[n_size];
            for (int i = 0; i < n_size; i++)
                myArray[i] = Convert.ToInt32(Console.ReadLine());
            int s = Convert.ToInt32(Console.ReadLine());
            Queue<int> queue = new Queue<int>();
            int sum_queue = 0;
            foreach (int item in myArray)
            {
                queue.Enqueue(item);
                sum_queue += item;
                while (sum_queue > s)
                {
                    sum_queue -= queue.Dequeue();
                }
                if (sum_queue == s) break;
            }
            if (sum_queue == s)
                foreach (int item in queue)
                    Console.Write("{0} ", item);
            else Console.Write(-1);
            //Kiểm Thử 4: 80ms
        }
    }
}


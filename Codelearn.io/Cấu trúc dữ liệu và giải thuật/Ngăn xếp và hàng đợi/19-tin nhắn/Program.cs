using System;
using System.Collections.Generic;
namespace _19_tin_nhắn
{
    class Program
    {
        static void messages_display(List<int> messages, int limit_display)
        {
            Queue<int> display_queue = new Queue<int>();
            foreach (int item in messages)
            {
                if (!display_queue.Contains(item))
                {
                    if (display_queue.Count == limit_display)
                    {
                        display_queue.Dequeue();
                        display_queue.Enqueue(item);
                    }
                    else
                    {
                        display_queue.Enqueue(item);
                    }
                }
            }
            while (display_queue.Count != 0)
                Console.Write("{0} ", display_queue.Dequeue());
        }

        static void Main(string[] args)
        {
            int n_size = Convert.ToInt32(Console.ReadLine());
            List<int> messages = new List<int>();
            for (int i = 0; i < n_size; i++)
                messages.Add(Convert.ToInt32(Console.ReadLine()));
            int limit_display = Convert.ToInt32(Console.ReadLine());
            messages_display(messages, limit_display);
        }
    }
}

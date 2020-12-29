using System;
using System.Collections.Generic;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();

            q.Enqueue(5);
            q.Enqueue(10);
            q.Enqueue(15);
            Console.Write("Queue: ");
            foreach (int i in q)
                Console.Write(i + " ");  // 5  10  15
            Console.Write("\nCount: " + q.Count);  // 3

            Console.Write("\nDequeue: " + q.Dequeue()); // 5

            Console.Write("\nQueue: ");
            foreach (int i in q)
                Console.Write(i + " ");  // 10  15
            Console.Write("\nCount: " + q.Count);  // 2
            Console.WriteLine();

            Queue<string> qu = new Queue<string>();
            qu.Enqueue("A");
            qu.Enqueue("B");
            qu.Enqueue("C");
            foreach (string s in qu)
                Console.Write(s + " ");
        }
    }
}

using System;
using System.Collections.Generic;
namespace _30_CircleLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            int n_size = Convert.ToInt32(Console.ReadLine());
            LinkedList<int> list = new LinkedList<int>();
            for (int i = 0; i < n_size; i++)
                list.AddLast(Convert.ToInt32(Console.ReadLine()));
            int k_index = Convert.ToInt32(Console.ReadLine());
            k_index %= n_size;
            LinkedListNode<int> node_k = list.First;
            while (--k_index >= 0)
            {
                node_k = node_k.Next;
            }
            LinkedListNode<int> node = node_k;
            do
            {
                Console.Write("{0} ", node.Value);
                node = node.Next;
                if (node == null) node = list.First;
            } while (node != node_k);

        }
    }
}

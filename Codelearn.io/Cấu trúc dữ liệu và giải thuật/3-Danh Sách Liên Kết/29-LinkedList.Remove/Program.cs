using System;
using System.Collections.Generic;
namespace _29_LinkedList.Remove
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
            LinkedListNode<int> node = list.First;
            if (k_index < n_size)
            {
                while (--k_index >= 0)
                {
                    node = node.Next;
                }
                list.Remove(node);
            }
            node = list.First;
            while (node != null)
            {
                Console.Write("{0} ", node.Value);
                node = node.Next;
            }

        }
    }
}
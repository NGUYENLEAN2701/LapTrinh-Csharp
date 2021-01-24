using System;
using System.Collections.Generic;
namespace _28_LinkedList.Insert
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
            int c_value = Convert.ToInt32(Console.ReadLine());
            LinkedListNode<int> node = list.First;
            if (k_index >= n_size) list.AddLast(c_value);
            else
            {
                while (--k_index >= 0)
                {
                    node = node.Next;
                }
                list.AddBefore(node, c_value);
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

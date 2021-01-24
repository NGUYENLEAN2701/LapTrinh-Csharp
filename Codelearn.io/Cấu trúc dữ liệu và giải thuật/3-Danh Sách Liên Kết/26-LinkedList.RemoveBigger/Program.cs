using System;
using System.Collections.Generic;
namespace _26_LinkedList.RemoveBigger
{
    class Program
    {
        static void Main(string[] args)
        {
            int n_size = Convert.ToInt32(Console.ReadLine());
            LinkedList<int> list = new LinkedList<int>();
            for (int i = 0; i < n_size; i++)
                list.AddLast(Convert.ToInt32(Console.ReadLine()));
            int k = Convert.ToInt32(Console.ReadLine());
            LinkedListNode<int> node = list.First;
            int value = node.Value;
            while (--k >= 0)
            {
                node = node.Next;
                if (node == null) break;
                value = node.Value;
            }
            node = list.First;
            while (node != null)
            {
                if (node.Value > value)
                {
                    if (node == list.Last)
                    {
                        list.Remove(node);
                        break;
                    }
                    node = node.Next;
                    list.Remove(node.Previous);

                }
                else
                {
                    Console.Write("{0} ", node.Value);
                    node = node.Next;
                }
            }
        }
    }
}

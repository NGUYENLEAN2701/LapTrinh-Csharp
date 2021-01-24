using System;
using System.Collections.Generic;
namespace _27_LinkedList_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            LinkedList<int> list = new LinkedList<int>();
            list.AddFirst(1);
            for (int i = 2; i <= n; i++)
            {
                list.AddFirst(i);
                list.AddLast(i);
            }
            LinkedListNode<int> node = list.First;
            while (node != null)
            {
                Console.Write("{0} ", node.Value);
                node = node.Next;
            }


        }
    }
}

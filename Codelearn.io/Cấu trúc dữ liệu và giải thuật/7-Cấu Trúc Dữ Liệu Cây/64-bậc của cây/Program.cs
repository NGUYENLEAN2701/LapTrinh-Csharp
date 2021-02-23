using System;

namespace _64_bậc_của_cây
{
    class Node
    {
        public int key;
        public Node left, right;
    }

    class Program
    {
        static Node insert(Node node, int data)
        {
            if (node == null)
            {
                Node temp = new Node();
                temp.key = data;
                temp.left = null;
                temp.right = null;
                return temp;
            }
            else
            {
                if (data < node.key)
                {
                    node.left = insert(node.left, data);
                }
                else
                {
                    node.right = insert(node.right, data);
                }
            }
            return node;
        }


        static int treeLevel(Node node)
        {
            if (node == null) return -1;
            return 1 + Math.Max(treeLevel(node.left), treeLevel(node.right));
        }

        static void Main(string[] args)
        {
            Node root = null;
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
                root = insert(root, Convert.ToInt32(Console.ReadLine()));
            Console.Write(treeLevel(root));
        }
    }
}

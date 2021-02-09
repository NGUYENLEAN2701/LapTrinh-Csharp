using System;

namespace _63b_đếm_lá
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
        static bool isLeafNode(Node node)
        {
            return (node.left == null && node.right == null);
        }

        static int countLeafNode(Node node)
        {
            if (node == null) return 0;
            if (isLeafNode(node)) return 1;
            else return countLeafNode(node.left) + countLeafNode(node.right);
        }

        static void Main(string[] args)
        {
            Node root = null;
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
                root = insert(root, Convert.ToInt32(Console.ReadLine()));
            Console.Write(countLeafNode(root));
        }
    }
}

using System;

namespace _66_biến_đổi_thành_cây_avl
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
        static bool checkAvl(Node node)
        {
            if (node == null) return true;
            if (Math.Abs(treeLevel(node.left) - treeLevel(node.right)) > 1) return false;
            return (checkAvl(node.left) && checkAvl(node.right));
        }
        static void printTree(Node node)
        {
            if (node != null)
            {
                printTree(node.left);
                Console.Write(node.key + " ");
                printTree(node.right);
            }
        }
        static void Main(string[] args)
        {
            Node root = null;
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
                root = insert(root, Convert.ToInt32(Console.ReadLine()));
            Console.Write(checkAvl(root) + " ");
            printTree(root);
        }
    }
}

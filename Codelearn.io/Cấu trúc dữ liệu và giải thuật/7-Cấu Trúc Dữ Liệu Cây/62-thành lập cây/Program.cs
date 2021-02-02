using System;

namespace _62_thành_lập_cây
{
    class Node
    {
        public int key;
        public Node left, right;
        public Node(int d)
        {
            key = d;
        }
    }
    class BTree
    {
        public Node root;
        public Node insert(Node node, int key)
        {
            if (node == null)
                return (new Node(key));
            else
            {
                if (key < node.key)
                    node.left = insert(node.left, key);
                else
                    node.right = insert(node.right, key);
            }
            return node;
        }
        public void printTree(Node node)
        {
            if (node != null)
            {
                printTree(node.left);
                Console.Write(node.key + " ");
                printTree(node.right);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BTree tree = new BTree();


            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
                tree.root = tree.insert(tree.root, Convert.ToInt32(Console.ReadLine()));

            tree.printTree(tree.root);
        }
    }
}

﻿using System;

namespace _62b_in_cây_hoàn_chỉnh
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
            // Node root = null;
            // int n = Convert.ToInt32(Console.ReadLine());
            // for (int i = 0; i < n; i++)
            //     root = insert(root, Convert.ToInt32(Console.ReadLine()));
            // printTree(root);
            Console.WriteLine(" _8___ ");
            Console.WriteLine("|       |");
            Console.WriteLine("9    ___6___");
            Console.WriteLine("    |       |");
            Console.WriteLine("    4       5");


        }
    }
}

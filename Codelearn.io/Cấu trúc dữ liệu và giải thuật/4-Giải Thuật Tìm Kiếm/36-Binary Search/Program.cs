using System;
using System.Collections.Generic;
namespace _36_Binary_Search
{
    class Program
    {
        static int binSearch_List(List<int> list, int value)
        {
            int Left = 0;
            int Right = list.Count - 1;
            while (Left < Right)
            {
                int Mid = (Left + Right) / 2;
                if (list[Mid] < value)
                {
                    Left = Mid + 1;
                }
                else
                {
                    Right = Mid;
                }
            }
            if (list[Left] == value) return Left;
            return -1;
        }
        static void Main(string[] args)
        {
            int n_size = Convert.ToInt32(Console.ReadLine());
            List<int> list = new List<int>();
            for (int i = 0; i < n_size; i++)
                list.Add(Convert.ToInt32(Console.ReadLine()));
            list.Sort();
            int value = Convert.ToInt32(Console.ReadLine());
            Console.Write(binSearch_List(list, value));
        }
    }
}

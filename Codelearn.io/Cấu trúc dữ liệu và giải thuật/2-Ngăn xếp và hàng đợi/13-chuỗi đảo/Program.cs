using System;
using System.Collections;
namespace _13_chuỗi_đảo
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Stack c = new Stack();
            for (int i = 0; i < s.Length; i++)
            {
                c.Push(s[i]);
            }
            while (c.Count != 0)
            {
                Console.Write(c.Pop());
            }
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        // Printing BitArray
        public static void PrintBarr(string name, BitArray ba)
        {
            Console.Write(name + " : ");
            for (int x = 0; x < ba.Length; x++)
                Console.Write(ba.Get(x) + " ");
            Console.WriteLine();
        }

        public static void Main(string[] args)
        {
            BitArray ba1 = new BitArray(4);
            BitArray ba2 = new BitArray(4);

            ba1.SetAll(true);
            ba2.SetAll(false);

            ba1.Set(2, false);
            ba2.Set(3, true);

            PrintBarr("ba1", ba1);
            PrintBarr("ba2", ba2);
            Console.WriteLine();

            PrintBarr("ba1 AND ba2", ba1.And(ba2));
            PrintBarr("    NOT ba2", ba2.Not());

            BitArray ba3 = new BitArray(4);
            BitArray ba4 = new BitArray(4);
            ba3.SetAll(true);
            ba4.SetAll(false);
            ba3.Set(2, false);
            ba4.Set(3, true);
            Console.Write(ba3.And(ba4).Get(3));
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedArr = new int[][]
            {
                new int[ ] {1,8,2,7,9},
                new int[ ] {2,4,6},
                new int[ ] {33,42}
            };
            int x = jaggedArr[2][1];
            Console.WriteLine(x);
            Console.WriteLine();
            foreach (int k in jaggedArr[2])
            {
                Console.WriteLine(k);
            }
        }
    }
}
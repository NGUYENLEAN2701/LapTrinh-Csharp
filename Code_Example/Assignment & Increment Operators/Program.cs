using System;
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
            int x = 1;
            Console.WriteLine("x += 2  : {0}", x += 2);
            Console.WriteLine("x -= 8  : {0}", x -= 8);
            Console.WriteLine("x *= 15 : {0}", x *= 15);
            Console.WriteLine("x /= 4  : {0}", x /= 4);
            Console.WriteLine("x %= 7  : {0}", x %= 7);
            int y = x++;
            Console.WriteLine("y = x++ : x = {0}; y = {1}", x, y);
            int z = ++y;
            Console.WriteLine("z = ++y : y = {0}; z = {1}", y, z);
            int a = 4;
            int b = 6;
            b = a++;
            Console.WriteLine(++b);
            int e = 15;
            int d = 6;
            e %= d;
            Console.WriteLine(e);
        }
    }
}

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
            int x = 25;
            int y = 7;
            Console.WriteLine("+ : {0}", x + y);
            Console.WriteLine("- : {0}", x - y);
            Console.WriteLine("* : {0}", x * y);
            Console.WriteLine("/ : {0}", x / y);
            Console.WriteLine("% : {0}", x % y);
            Console.WriteLine(x ^ y);
            Console.WriteLine(x | y);
            Console.WriteLine(x & y);
            y = x;
            Console.WriteLine(x & y);
            x = (4 + 3) * 2;//Operator Precedence
            Console.WriteLine(x);//14

        }
    }
}

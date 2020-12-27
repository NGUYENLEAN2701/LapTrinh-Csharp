using System;

namespace Named_Arguments
{
    class Program
    {
        static int Area(int h = 1, int w = 1)
        {
            return h * w;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Area());
            int res = Area(w: 5, h: 8);
            Console.WriteLine(res);
        }

    }
}

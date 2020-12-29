using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sat };
        enum Test { a = 2, b, c, d, e };
        enum TrafficLights { Green, Red, Yellow };
        static void Main(string[] args)
        {
            int z = (int)Days.Tue;
            Console.WriteLine(z);
            int y = (int)Test.c;
            Console.WriteLine(y);

            TrafficLights x = TrafficLights.Red;
            switch (x)
            {
                case TrafficLights.Green:
                    Console.WriteLine("Go!");
                    break;
                case TrafficLights.Red:
                    Console.WriteLine("Stop!");
                    break;
                case TrafficLights.Yellow:
                    Console.WriteLine("Caution!");
                    break;
            }
        }
    }
}

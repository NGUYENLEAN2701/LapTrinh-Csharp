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
            do
            {
                try
                {
                    Console.Write("drinks = ");
                    int drinks = Convert.ToInt32(Console.ReadLine());
                    Console.Write("shelves = ");
                    int shelves = Convert.ToInt32(Console.ReadLine());

                    //your code goes here
                    Console.WriteLine(drinks / shelves);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("At least 1 shelf");
                    continue;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please insert an integer");
                    continue;
                }
                break;
            } while (true);
            /*
             * 1. DivideByZeroException => "At least 1 shelf"
             * 2. FormatException => "Please insert an integer"
            */

        }
    }
}
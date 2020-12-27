using System;

namespace Overloading
{
    class Program
    {
        static void Print(int a)
        {
            Console.WriteLine("Value: " + a);
        }
        static void Print(double a)
        {
            Console.WriteLine("Value: " + a);
        }
        static void Print(string label, double a)
        {
            Console.WriteLine(label + a);
        }
        static void Main(string[] args)
        {
            Print(11);
            Print(4.13);
            Print("Average: ", 7.57);
        }
    }
}

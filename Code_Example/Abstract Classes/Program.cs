using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        abstract class Shape
        {
            public abstract void Draw();
        }
        class Circle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Circle Draw");
            }
        }
        class Rectangle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Rect Draw");
            }
        }
        static void Main(string[] args)
        {
            Shape c = new Circle();
            c.Draw();
        }
    }
}
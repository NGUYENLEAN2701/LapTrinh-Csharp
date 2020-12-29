using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        class Animal
        {
            public int Legs { get; set; }
            public int Age { get; set; }
        }
        class Dog : Animal
        {
            public Dog()
            {
                Legs = 4;
            }
            public void Bark()
            {
                Console.Write("Woof");
            }
        }
        static void Main(string[] args)
        {
            Dog d = new Dog();
            Console.WriteLine(d.Legs);

            d.Bark();
        }
    }
}
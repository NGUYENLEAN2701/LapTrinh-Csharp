using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        class Dog
        {
            public Dog()
            { Console.WriteLine(1); }

            public Dog(string name)
            { Console.WriteLine(name); }
        }
        static void Main(string[] args)
        {
            Dog d = new Dog("2");
        }

    }

}

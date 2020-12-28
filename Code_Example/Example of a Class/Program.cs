using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_of_a_Class
{
    class Program
    {
        class Person
        {
            int age = 1;
            public string name = "name";
            public void SayHi()
            {
                Console.WriteLine("Hi");
                Console.WriteLine(age);
                Console.WriteLine(name);
            }
        }
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.name = "Test!";
            p1.SayHi();
        }
    }

}

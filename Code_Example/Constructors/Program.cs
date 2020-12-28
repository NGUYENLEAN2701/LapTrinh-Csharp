using System;

namespace Constructors
{
    class Program
    {
        class Person
        {
            private int age;
            private string name;
            public Person(string nm)
            {
                name = nm;
                age = 1;
            }
            public string getName()
            {
                return name;
            }
            public int getAge()
            {
                return age;
            }
        }
        static void Main(string[] args)
        {
            Person p = new Person("David");
            Console.WriteLine(p.getName());
            Console.WriteLine(p.getAge());
        }
    }
}
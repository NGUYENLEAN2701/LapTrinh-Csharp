using System;
using System.Collections.Generic;
namespace _9_Coffee_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            int discount = Convert.ToInt32(Console.ReadLine());

            Dictionary<string, int> coffee = new Dictionary<string, int>();
            coffee.Add("Americano", 50);
            coffee.Add("Latte", 70);
            coffee.Add("Flat White", 60);
            coffee.Add("Espresso", 60);
            coffee.Add("Cappuccino", 80);
            coffee.Add("Mocha", 90);


            //your code goes here
            foreach (string s in coffee.Keys)
                Console.WriteLine(s + ": " + Math.Round((double)coffee[s] * (100 - discount) / 100, MidpointRounding.AwayFromZero));
        }
    }
}

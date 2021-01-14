using System;
using System.Collections;
namespace _14_chuyển_nhị_phân
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            // string binary = Convert.ToString(n,2);
            // Console.WriteLine(binary);
            Stack binary = new Stack();
            while (n>0){
                binary.Push(n%2);
                n/=2;
            }
            foreach (Object obj in binary)
                Console.Write(obj);
        }
    }
}

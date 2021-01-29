using System;

namespace _58_in_chuỗi_nhị_phân
{
    class Program
    {
        static void chuoinhiphan(int n)
        {
            string binary = Convert.ToString(n, 2);
            Console.Write("{0} ", binary);
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            
        }
    }
}

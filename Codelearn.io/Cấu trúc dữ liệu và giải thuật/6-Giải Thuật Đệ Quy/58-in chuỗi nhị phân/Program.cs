using System;

namespace _58_in_chuỗi_nhị_phân
{
    class Program
    {
        static void chuoinhiphan(int n, string s)
        {
            if (n == 0) Console.Write("{0} ", s);
            else
            {
                for (int i = 0; i <= 1; i++)
                {
                    chuoinhiphan(n - 1, s + (char)(i + '0'));
                }
            }
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            chuoinhiphan(n, "");
        }
    }
}

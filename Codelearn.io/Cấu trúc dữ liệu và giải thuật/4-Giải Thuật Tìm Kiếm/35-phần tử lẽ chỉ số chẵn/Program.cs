using System;
using System.Collections.Generic;
namespace _35_phần_tử_lẽ_chỉ_số_chẵn
{
    class Program
    {
        static void Main(string[] args)
        {
            int n_size = Convert.ToInt32(Console.ReadLine());
            List<int> list = new List<int>();
            for (int i = 0; i < n_size; i++)
                list.Add(Convert.ToInt32(Console.ReadLine()));
            int count = 0;
            for (int i = 0; i < n_size; i += 2)
            {
                if ((list[i] % 2) != 0)
                {
                    Console.Write("{0} ", list[i]);
                    count++;
                }
            }
            if (count == 0) Console.Write("NULL");
        }
    }
}

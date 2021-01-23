using System;
using System.Collections;
namespace _15_mã_hóa_chuỗi
{
    class Program
    {
        static string EncodeStr(string s)
        {
            string encode_s = "";
            int count = 1;
            char old_item = s[0];
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == old_item) count++;
                else
                {
                    encode_s += old_item;
                    encode_s += count.ToString();
                    old_item = s[i];
                    count = 1;
                }
            }
            encode_s += old_item;
            encode_s += count.ToString();
            return encode_s;
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Console.WriteLine(EncodeStr(s));
        }
    }
}

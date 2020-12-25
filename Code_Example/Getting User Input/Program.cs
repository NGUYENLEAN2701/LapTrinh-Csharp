using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            string yourName;
            Console.Write("Xin nhập tên bạn: ");
            yourName = Console.ReadLine();

            Console.Write("Xin nhập tuổi của bạn: ");
            uint age = 0;
            while (!uint.TryParse(Console.ReadLine(), out age))
            {
                Console.Write("Bạn nhập sai - thử lại: ");
            }
            Console.WriteLine("Xin chào {0} {1} tuổi", yourName, age);

        }
    }
}
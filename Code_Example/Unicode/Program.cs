using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Hello World!");
            Console.Write("Xin Nhập Tên Bạn: ");
            string Name = Console.ReadLine();
            Console.WriteLine("Chào Mừng {0} Đến Với C#", Name);
            var ps = new ProcessStartInfo("https://nguyenlean.com/index.php")
            {
                UseShellExecute = true,
                Verb = "open"
            };
            Process.Start(ps);
        }
    }
}

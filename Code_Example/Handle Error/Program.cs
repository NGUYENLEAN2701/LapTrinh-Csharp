using System;

namespace Handle_Error
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            try
            {
                x /= x;
                x += 1;
            }
            catch (Exception e)
            {
                x += 3;
            }
            finally
            {
                x += 4;
            }
            Console.WriteLine(x);
        }
    }
}

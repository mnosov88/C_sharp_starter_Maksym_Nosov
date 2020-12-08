using System;

namespace Lesson3_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10, y = 12, z = 3;
            x += y - x++ * z;
            Console.WriteLine(x);


            Console.ReadKey();
        }
    }
}

using System;

namespace Lesson3_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2, y = 5, z = 7;
            float avarage = (x + y + z) / 3;
            
            //why if type of result is float value is not float
            Console.WriteLine(avarage);
            Console.ReadKey();
        }
    }
}

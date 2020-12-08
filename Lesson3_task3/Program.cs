using System;

namespace Lesson3_task3
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14;
            Console.Write("Enter value for radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double circleSquare = pi * Math.Pow(radius, 2);
            Console.WriteLine($"Circle square is: {circleSquare}");

            //pause
            Console.ReadKey();
        }
    }
}

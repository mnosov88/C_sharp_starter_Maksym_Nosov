using System;

namespace Lesson3_task4
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14;
            Console.Write("Enter radius value: ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter height value: ");
            double h = Convert.ToDouble(Console.ReadLine());

            double V = pi * Math.Pow(r, 2) * h;
            double S = 2* pi * r * (r + h);

            Console.WriteLine($"Value of cylinder volume is: {V}");
            Console.WriteLine($"Value of cylinder surface square is: {S}");

            // pause
            Console.ReadKey();
        }
    }
}

using System;

namespace Lesson4_task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value from 0 to 100: ");
            double value;

            try
            {
                value = Convert.ToDouble(Console.ReadLine());

                if (value >= 0 && value <= 14)
                {
                    Console.WriteLine("Entered by you number is contained in 0-14 range");
                    Console.ReadKey();
                }
                else if (value >= 15 && value <= 35)
                {
                    Console.WriteLine("Entered by you number is contained in 15-35 range");
                    Console.ReadKey();
                }
                else if (value >= 36 && value <= 50)
                {
                    Console.WriteLine("Entered by you number is contained in 36-50 range");
                    Console.ReadKey();
                }
                else if (value >= 50 && value <= 100)
                {
                    Console.WriteLine("Entered by you number is contained in 50-100 range");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("You entered out of range value. Try again :) ");
                    Console.ReadKey();
                }
            }
            catch (SystemException e)
            {
                Console.WriteLine("You entered not valid value. Exception occurred: {0}", e.Message);
                Console.WriteLine("Please, try to enter digit value");
                Console.ReadKey();
            }
        }
    }
}

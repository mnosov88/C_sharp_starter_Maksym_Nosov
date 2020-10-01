/*
 Задание 2
Используя Visual Studio, создайте проект по шаблону Console Application.
Напишите программу - консольный калькулятор.
Создайте две переменные с именами operand1 и operand2. Задайте переменным некоторые
произвольные значения. Предложите пользователю ввести знак арифметической операции. Примите
значение, введенное пользователем, и поместите его в строковую переменную sign.
Для организации выбора алгоритма вычислительного процесса, используйте переключатель switch.
Выведите на экран результат выполнения арифметической операции.
В случае использования операции деления, организуйте проверку попытки деления на ноль. И если
таковая имеется, то отмените выполнение арифметической операции и уведомите об ошибке
пользователя.
 */

using System;
using System.Diagnostics;
using System.Linq;

namespace Lesson4_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter sign: ");
            string sign = Convert.ToString(Console.ReadLine());
            string[] array = { "+", "-", "*", "/" };

            if (array.Contains(sign))
            {
                Console.WriteLine("Please, enter value of operand1: ");
                double operand1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please, enter value of operand1: ");
                double operand2 = Convert.ToDouble(Console.ReadLine());

                double result = 0;

                switch (sign)
                {
                    case "+":
                        {
                            result = operand1 + operand2;
                            break;
                        }
                    case "-":
                        {
                            result = operand1 - operand2;
                            break;
                        }
                    case "*":
                        {
                            result = operand1 * operand2;
                            break;
                        }
                    case "/":
                        {
                            if (operand2 == 0)
                            {
                                Console.WriteLine("Division by 0 is not acceptable");
                            }
                            else
                            {
                                result = operand1 / operand2;
                            }
                            break;
                        }
                }
                Console.WriteLine("Great! Your result is {0}.", result);
                Console.ReadKey();

            } 
            else 
            {
                Console.WriteLine("You entered not valid sign. Try one of those: +, -, *, /");
                Console.ReadKey();
            }
        }
    }
}

using System;

namespace Task_8
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Задача 8: Напишите программу, которая на вход принимает число(N),
            а на выходе показывает все чётные числа от 1 до N.

            5 -> 2, 4
            8 -> 2, 4, 6, 8*/
            
            Console.Write("Введите число N: ");
            int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
            if (number > 1)
            {
                Console.Write($"Ответ: Все чётные числа от 1 до {number}: ");
                for (int i = 1; i <= number; i++)
                {
                    if (i % 2 == 0)
                    {
                        if (i == number || i == number - 1) Console.Write($"{i}.");
                        else Console.Write($"{i}, ");
                    }
                }
            }
            else if (number == 1) Console.WriteLine($"Ответ: Чётных чисел в промежутке от 1 до {number}, Нет.");
            else Console.WriteLine("Ответ: Чётных чисел нет, Вы задали число меньше 1.");
        }
    }
}
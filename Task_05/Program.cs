using System;

namespace Task_5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Задача 5: Напишите программу, которая на вход принимает одно число (N),
                а на выходе показывает все целые числа в промежутке от -N до N.

                4 -> "-4 -3 -2 -1 0 1 2 3 4"
                2 -> "-2 -1 0 1 2"*/
            
            Console.Write("Введите число N: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ответ: ");
            number = Math.Abs(number);
            for (int i = -number; i <= number; i++)
            {
                if (number == 0 || number == 1)
                {
                    Console.Write("Из целых чисел осталься только 0");
                    break;
                }
                else if (i % 2 == 0)
                {
                    if (i != number && i != number - 1)
                    {
                        Console.Write($"{i}, ");
                    }
                    else Console.Write($"{i}.");
                }
            }
        }
    }
}
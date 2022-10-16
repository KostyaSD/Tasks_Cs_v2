using System;

namespace Task_22
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Задача 22: Напишите программу, которая принимает на вход число (N)
             и выдаёт таблицу квадратов чисел от 1 до N.

             5 -> 1, 4, 9, 16, 25.
             2 -> 1, 4.*/
            
            Console.Write("Введите число N: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine($"Ответ: Таблица кубов чисел от 1 до {num}:");
                for (int i = 1; i <= num; i++)
                {
                    Console.WriteLine($"{i}^2 = {Math.Pow(i, 2)} ");
                }
            }
            else Console.WriteLine($"Ответ: Число {num} не попало в интервал от 1");
        }
    }
}
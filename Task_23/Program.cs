using System;

namespace Task_23
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Задача 23: Напишите программу, которая принимает на вход число (N)
             и выдаёт таблицу кубов чисел от 1 до N.

             3 -> 1, 8, 27
             5 -> 1, 8, 27, 64, 125*/
            
            Console.Write("Введите число N: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine($"Ответ: Таблица кубов чисел от 1 до {num}:");
                for (int i = 1; i <= num; i++)
                {
                    Console.WriteLine($"{i}^3 = {Math.Pow(i, 3)} ");
                }
            }
            else Console.WriteLine($"Ответ: Число {num} не попало в интервал от 1");
        }
    }
}
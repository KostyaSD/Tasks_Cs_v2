using System;

namespace Task1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Задача 1: Напишите программу, которая на вход принимает два числа и проверяет,
                является ли первое число квадратом второго

                a = 5; b = 25 -> Да
                a = 2 b = 10 -> Нет
                a = 9 b = -3 -> Нет
                a = -3 b = 9 -> Да */

            Console.Write("Введите первое число: ");
            int numberA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int numberB = Convert.ToInt32(Console.ReadLine());
            if (numberB == (numberA * numberA)) Console.WriteLine("Ответ: Да, является.");
            else Console.WriteLine("Ответ: Нет, не является.");
        }
    }
}
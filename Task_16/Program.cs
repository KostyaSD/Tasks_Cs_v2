using System;

namespace Task_16
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Задача 16: Напишите программу, которая принимает на вход два числа и проверяет,
             является ли одно число квадратом другого.

             5, 25 -> Да
             4, 16 -> Да
             25, 5 -> Да
             8, 9 -> Нет*/
            
            Console.Write("Введите первое число: ");
            int numA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int numB = Convert.ToInt32(Console.ReadLine());
            if (numA == Math.Pow(numB, 2) || numB == Math.Pow(numA, 2)) Console.WriteLine("Ответ: Да, является.");
            else Console.WriteLine("Ответ: Нет, не является.");
        }
    }
}
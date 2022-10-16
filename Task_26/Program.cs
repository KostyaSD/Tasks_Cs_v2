using System;

namespace Task_26
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Задача 26: Напишите программу, которая принимает на вход число и выдаёт
             количество цифр в числе.

             456 -> 3
             78 -> 2
             89126 -> 5*/
            
            Console.Write("Введите число: ");
            int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
            string tNum = num.ToString();
            Console.Write($"Ответ: Количество цифр в числе: {tNum.Length}");
        }
    }
}
using System;

namespace Task_10
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Задача 10: Напишите программу, которая принимает на вход трёхзначное число
             и на выходе показывает вторую цифру этого числа.

             456 -> 5
             782 -> 8
             918 -> 1*/
            
            Console.Write("Введите трёхзначное число: ");
            int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
            string tNum = number.ToString();
            if (tNum.Length == 3) Console.WriteLine($"Ответ: {number / 10 % 10}");
            else Console.WriteLine("Вы ввели не трёхзначное число");
        }
    }
}
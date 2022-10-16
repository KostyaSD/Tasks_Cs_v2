using System;

namespace Task_7
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Задача 7: Напишите программу, которая принимает на вход трёхзначное число
            и на выходе показывает последнюю цифру этого числа.

            456 -> 6
            782 -> 2
            918 -> 8*/
            
            Console.Write("Введите трёхзначное число: ");
            int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
            string tNum = number.ToString();
            if (tNum.Length == 3) Console.WriteLine($"Ответ: {number % 10}");
            else Console.WriteLine("Вы ввели не трёхзначное число");
        }
    }
}
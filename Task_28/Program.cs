using System;

namespace Task_28
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Задача 28: Напишите программу, которая принимает на вход число N и выдает
             произведение чисел от 1 до N.

             4 -> 24
             5 -> 120*/
            
            Console.Write("Введите число N: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 1;
            if (num > 1)
            {
                for (int i = 1; i <= num; i++)
                {
                    count *= i;
                }
                Console.Write($"Ответ: Произведение чисел от 1 до {num} = {count}");
            }
            else Console.Write("Ответ: Прочитайте внимательно условие \"от 1\", это значит первая цифра 2!");
        }
    }
}
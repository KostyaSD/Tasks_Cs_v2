using System;

namespace Task_14
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Задача 14: Напишите программу, которая принимает на вход число и проверяет,
             кратно ли оно одновременно 7 и 23.

             14 -> Нет
             46 -> Нет
             161 -> Да*/
            
            Console.Write("Введите число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 7 == 0 && num % 23 == 0) Console.WriteLine($"Ответ: Да, число {num} одновременно " +
                                                                   "кратно 7 и 23.");
            else Console.WriteLine($"Ответ: Нет, число {num} одновременно не кратно 7 и 23.");
        }
    }
}
using System;

namespace Task_12
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Задача 12: Напишите программу, которая будет принимать на вход два числа
             и выводить, является ли первое число кратным второму. Если 1 не кратно числу 2,
             то программа выводит остаток от деления.

             34, 5 -> не кратно, остаток 4
             16, 4 -> кратно*/
            
            Console.Write("Введите первое число: ");
            int numA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int numB = Convert.ToInt32(Console.ReadLine());
            if (numB == 0) Console.WriteLine($"Ответ: На {numB} делить нельзя!");
            else if (numA % numB == 0) Console.WriteLine("Ответ: Кратно");
            else Console.WriteLine($"Ответ: Не кратно, остаток {numA % numB}");
        }
    }
}
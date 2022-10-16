using System;

namespace Task_15
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Задача 15: Напишите программу, которая принимает на вход цифру,
             обозначающую день недели, и проверяет, является ли этот день выходным.

             6 -> да
             7 -> да
             1 -> нет*/
            
            Console.Write("Введите день недели: ");
            int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
            if (num > 0 && num <= 5) Console.Write("Ответ: Нет, сегодня не выходной.");
            else if (num > 5 && num <= 7) Console.Write("Ответ: Да, сегодня выходной день.");
            else Console.Write($"Число: {num}, не попало в промежуток дней недели от 1 до 7.");
        }
    }
}
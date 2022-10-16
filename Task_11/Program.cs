using System;

namespace Task_11
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Задача 11: Напишите программу, которая выводит случайное трёхзначное
             число и удаляет вторую цифру этого числа.

             456 -> 46
             782 -> 72
             918-> 98*/
            
            int numA = new Random().Next(100, 1000);
            Console.WriteLine($"Случайное число: {numA}");
            int numB = numA % 10;
            Console.WriteLine($"Ответ: {numA / 100}{numB}");
        }
    }
}
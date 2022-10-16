using System;

namespace Task_9
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Задача 9: Напишите программу, которая выводит случайное число
            из отрезка [10, 99] и показывает наибольшую цифру числа.

            78 -> 8
            12 -> 2
            85 -> 8*/
            
            int number = new Random().Next(10, 100);
            Console.WriteLine($"Случайное число: {number}");
            if (number / 10 > number % 10) Console.WriteLine($"Наибольшая цифра числа: {number / 10}");
            else Console.WriteLine($"Ответ: Наибольшая цифра числа: {number % 10}");
        }
    }
}
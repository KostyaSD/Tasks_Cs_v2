using System;

namespace Task_18
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Задача 18: Напишите программу, которая по заданному номеру четверти,
             показывает диапазон возможных координат точек в этой четверти (х, y).

             1 -> (x > 0, y > 0)
             2 -> (x < 0, y > 0)*/
            
            Console.Write("Введите номер четверти: ");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.Write("Ответ: Точка находится в диапозоне (x > 0, y > 0).");
                    break;
                case 2:
                    Console.Write("Ответ: Точка находится в диапозоне (x < 0, y > 0).");
                    break;
                case 3:
                    Console.Write("Ответ: Точка находится в диапозоне (x < 0, y < 0).");
                    break;
                case 4:
                    Console.Write("Ответ: Точка находится в диапозоне (x > 0, y < 0).");
                    break;
                default:
                    Console.Write("Ответ: К сожалению в нашем случае четверти бывают от 1 до 4.");
                    break;
            }
        }
    }
}
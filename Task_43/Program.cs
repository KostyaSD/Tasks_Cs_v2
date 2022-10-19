using System;

namespace Task_43
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Задача 43: Дз. Напишите программу, которая найдёт точку пересечения двух прямых,
                         заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
                         задаются пользователем.

                         b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/
            
            Console.Write("Введите b1: ");
            double b1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите k1: ");
            double k1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите b2: ");
            double b2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите k2: ");
            double k2 = Convert.ToInt32(Console.ReadLine());
            
            IntersTwoLines(b1, k1, b2, k2);
        }

        private static void IntersTwoLines(double b1, double k1, double b2, double k2)
        {
            //y = k1 * x + b1;
            //y = k2 * x + b2;
            //k1 * x + b1 = k2 * x + b2;
            //k1 * x - k2 * x = b2 - b1;
            //x*(k1 - k2) = b2 - b1;
            
            double x = (b2 - b1) / (k1 - k2);
            //y = k1 * x + b1; подставляем 'x' в одно из двух выражений(я выбрал второе)
            double y = k2 * x + b2;
            x = Math.Round(x, 2); // на случай если будет много цифр после запятой
            y = Math.Round(y, 2);
            Console.WriteLine($"Точка пересечения двух прямых: ({x}, {y})");
        }
    }
}
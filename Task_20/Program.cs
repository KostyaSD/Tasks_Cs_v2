using System;

namespace Task_20
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Задача 20: Напишите программу, которая принимает на вход координаты двух точек
             и находит расстояние между ними в 2D пространстве.

             A (3,6); B (2,1), -> 5.09
             A (7,-5); B (1,-1) -> 7.21*/
            
            Console.Write("Введите координату x1: ");
            int numXa = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату y1: ");
            int numYa = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату x2: ");
            int numXb = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату y2: ");
            int numYb = Convert.ToInt32(Console.ReadLine());
            double d = Math.Pow((Math.Pow(numXb - numXa, 2) +
                                 Math.Pow(numYb - numYa, 2)), 0.5);
            d = Math.Round(d, 2);
            Console.WriteLine("Ответ: Расстояние между точками в 2D пространстве = " + d);
        }
    }
}
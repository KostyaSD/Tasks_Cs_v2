using System;

namespace Task_21
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Задача 21: Напишите программу, которая принимает на вход координаты двух точек 
             и находит расстояние между ними в 3D пространстве.

             A (3,6,8); B (2,1,-7), -> 15.84
             A (7,-5, 0); B (1,-1,9) -> 11.53*/
            
            Console.Write("Введите координату x1: ");
            int numXa = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату y1: ");
            int numYa = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату z1: ");
            int numZa = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату x2: ");
            int numXb = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату y2: ");
            int numYb = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату z2: ");
            int numZb = Convert.ToInt32(Console.ReadLine());
            double d = Math.Pow((Math.Pow(numXb - numXa, 2) +
                                 Math.Pow(numYb - numYa, 2) +
                                 Math.Pow(numZb - numZa, 2)), 0.5);
            d = Math.Round(d, 2);
            Console.WriteLine("Ответ: Расстояние между точками в 3D пространстве = " + d);
        }
    }
}
using System;

namespace Task_40
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Задача 40: Напишите программу, которая принимает на вход три числа и проверяет,
                         может ли существовать треугольник с сторонами такой длины.
                         Теорема о неравенстве треугольника: каждая сторона треугольника меньше 
                         суммы двух других сторон.*/
            
            Console.WriteLine("Введите 3 числа");

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            if (a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine("Это треугольник");
            }
            else Console.WriteLine("Это не треугольник");
        }
    }
}
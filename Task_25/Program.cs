using System;

namespace Task_25
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /* Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
              и возводит число A в натуральную степень B.

              3, 5 -> 243 (3⁵)
              2, 4 -> 16*/
            
            Console.Write("Введите число А: ");
            int numA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число В: ");
            int numB = Convert.ToInt32(Console.ReadLine());
            
            //1 вариант решения:
            Console.WriteLine($"Ответ: {Math.Pow(numA, numB)}");
            
            //2 вариант решения:
            /*int count = num1; 
            for(int i = 1; i < num2; i++)
            {
                count *= num1;
            }
            Console.WriteLine($"Ответ: {count}");*/
        }
    }
}
using System;
using System.Globalization;

namespace Task_47
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Задача 47: Задайте двумерный массив размером m×n, заполненный случайными
                         вещественными числами.

                         m = 3, n = 4.
                         0,5 7 -2 -0,2
                         1 -3,3 8 -9,9
                         8 7,8 -7,1 9*/

            Console.Write("Введите размер массива m x n:\n" +
                          "m: ");
            int numArrM = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("n: ");
            int numArrN = Convert.ToInt32(Console.ReadLine());
            
            double[,] arr = new Double[numArrM, numArrN];

            FillArray(arr);
            PrintArray(arr);
        }
        
        private static void PrintArray(double[,] arr)
        {
            //int lenght;
            int lenght;
            Console.WriteLine("Массив:");
            
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    lenght = arr[i, j].ToString(CultureInfo.InvariantCulture).Length;
                    // я не знаю что такое CultureInfo.InvariantCulture, но редактор рекомендует!
                    if (lenght == 1)      Console.Write($"     {arr[i, j]}");
                    else if (lenght == 2) Console.Write($"    {arr[i, j]}");
                    else if (lenght == 3) Console.Write($"   {arr[i, j]}");
                    else if (lenght == 4) Console.Write($"  {arr[i, j]}");
                    else                  Console.Write($" {arr[i, j]}");
                }
                Console.WriteLine();
            }
        }

        private static void FillArray(double[,] arr)
        {
            Random random = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = random.NextDouble() * random.Next(-32, 112);
                    arr[i, j] = Math.Round(arr[i, j], 1);
                } 
            }
        }
    }
}
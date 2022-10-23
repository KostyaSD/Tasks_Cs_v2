using System;
using System.Globalization;

namespace Task_52
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее
                         арифметическое элементов в каждом столбце.

                         Например, задан массив:
                         1 4 7 2
                         5 9 2 3
                         8 4 2 4
                         Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/
            
            Console.Write("Введите размер массива m x n:\n" +
                          "m: ");
            int numArrM = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("n: ");
            int numArrN = Convert.ToInt32(Console.ReadLine());

            int[,] arr = new int[numArrM, numArrN];

            FillArray(arr);
            PrintArray(arr);
            ArithmeticEachColumnArr(arr);
        }

        private static void ArithmeticEachColumnArr(int[,] arr)
        {
            Console.WriteLine("Суммы столбцов: ");
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                var count = 0; // редактор рекомендует var
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    count += arr[j, i];
                }
                var lenght = count.ToString(CultureInfo.InvariantCulture).Length;
                //редактор рекомендует CultureInfo.InvariantCulture!
                if (lenght == 1)      Console.Write($"   {count}");
                else if (lenght == 2) Console.Write($"  {count}");
                else                  Console.Write($" {count}");
            }
        }

        private static void FillArray(int[,] arr)
        {
            Random random = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = random.Next(-10, 20);
                }
            }
        }
        
        private static void PrintArray(int[,] arr)
        {
            Console.WriteLine("\nМассив: ");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    var lenght = arr[i, j].ToString(CultureInfo.InvariantCulture).Length;
                    //редактор рекомендует использовать var и CultureInfo.InvariantCulture!
                    if (lenght == 1)      Console.Write($"   {arr[i, j]}");
                    else if (lenght == 2) Console.Write($"  {arr[i, j]}");
                    else                  Console.Write($" {arr[i, j]}");
                }
                Console.WriteLine();
            }
        }
    }
}
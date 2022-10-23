using System;

namespace Task_48
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Задача 48: Задайте двумерный массив размера m на n, каждый элемент
                         в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
                         
                         m = 3, n = 4.
                         0 1 2 3
                         1 2 3 4
                         2 3 4 5*/
            
            int numArrM = 3;
            int numArrN = 4;

            int[,] arr = new int[numArrM, numArrN];

            FillArray(arr);
            PrintArray(arr);
        }
        private static void PrintArray(int[,] arr)
        {
            Console.WriteLine("Массив:");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] < 10 && arr[i, j] >= 0) Console.Write($"  {arr[i, j]} ");
                    else if (arr[i, j] < -9 || arr[i, j] > 99) Console.Write($"{arr[i, j]} ");
                    else Console.Write($" {arr[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        private static void FillArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = i + j;
                }
            }
        }
    }
}
using System;

namespace Task_46
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Задача 46: Задайте двумерный массив размера m на n, заполненный случайными
                         целыми числами.
             
                         m = 3, n = 4.
                         1 4 8 19
                         5 -2 33 -2
                         77 3 8 1*/

            //int numArr = Convert.ToInt32(Console.ReadLine());
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
            Random random = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = random.Next(-20, 120);
                }
            }
        }
    }
}
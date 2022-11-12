using System;
using System.Globalization;

namespace Task_53
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Задача 53: ??Задайте двумерный массив. Напишите программу, которая поменяет местами первую 
                         и последнюю строку массива.*/

            Console.Write("Задайте размер массива [m, n] (размер до 5 х 5):\n" +
                          "Введите число m: ");
            int numM = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Введите число n: ");
            int numN = Convert.ToInt32(Console.ReadLine());

            int[,] arr = new int[numM, numN];
            int[,] arr2 = new int[numN, numM];
            
            FillArray(arr);
            //PrintArray(arr);
            //RepMatrix(arr, 0, 0, arr2);
            try
            {
                PrintArray(arr);
                RepMatrix(arr, 0, 0, arr2);
                PrintArray(arr2);
            }
            catch 
            {
                Console.WriteLine("Невозможно!");
            }
        }

        private static void RepMatrix(int[,] arr, int y, int x, int[,] arr2)
        {
            if (x >= 0 && y >= 0 
                       && x != arr.GetLength(1) 
                       && y != arr.GetLength(0) 
                       && arr2[y, x] == 0)
            {
                arr2[y, x] = arr[x, y];
                RepMatrix(arr, y, x + 1, arr2);
                RepMatrix(arr, y + 1, x, arr2);
                RepMatrix(arr, y, x - 1, arr2);
                RepMatrix(arr, y - 1, x, arr2);
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
            int lenght;
            
            Console.WriteLine("Массив:");
            
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    lenght = arr[i, j].ToString(CultureInfo.InvariantCulture).Length;
                    if (lenght == 1)      Console.Write($"   {arr[i, j]}");
                    else if (lenght == 2) Console.Write($"  {arr[i, j]}");
                    else                  Console.Write($" {arr[i, j]}");
                }
                Console.WriteLine();
            }
        }
    }
}
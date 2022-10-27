using System;
using System.Globalization;

namespace Task_62
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Задача 62. ?Напишите программу, которая заполнит спирально массив 4 на 4.
             
                         Например, на выходе получается вот такой массив:
                         01 02 03 04
                         12 13 14 05
                         11 16 15 06
                         10 09 08 07*/

            int numM = 4;
            int numN = 4;

            int[,] arr = new int[numM, numN];
            int count = 1;
            FillArray(arr, 0, 0, count);
            PrintArray(arr);
            
        }

        private static void FillArray(int[,] arr, int y, int x, int count)
        {
            
            if (x >= 0 && y >= 0 && x != arr.GetLength(1) && y != arr.GetLength(0) && arr[y, x] == 0)
            {
                arr[y, x] = count;
                count++;
                
                FillArray(arr, y, x + 1, count);
                FillArray(arr, y + 1, x, count);
                FillArray(arr, y, x - 1, count);
                FillArray(arr, y - 1, x, count);

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
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
            
            Console.Write("Задайте размер массива [m, n]:\n" +
                          "Введите число m: ");
            int numM = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Введите число n: ");
            int numN = Convert.ToInt32(Console.ReadLine());

            int[,] arr = new int[numM, numN];
            
            SpirArr(arr, numM, numN); //для любого массива
            //FillArray(arr, 0, 0, 1);// рекурс для любых размеров до 5 х 5 (3 х 5; 2 х 4; 5 х 3)
            PrintArray(arr);
            
            
        }

        private static void SpirArr(int[,] arr, int rowNumber, int colNumber)
        {
            int max = rowNumber * colNumber;
            int minCol, minRow;
            minCol = minRow = 0;
            int count = 0;
            
            while (count < max)
            {
                for (int i = minCol; i < colNumber; i++)
                {
                    arr[minRow,i] = count;
                    count++;
                }
                
                minRow++;
                
                for (int i = minRow; i < rowNumber; i++)
                {
                    arr[i, colNumber - 1] = count;
                    count++;
                }

                colNumber--;
                
                for (int i = colNumber - 1; i >= minCol; i--)
                {
                    arr[rowNumber - 1, i] = count;
                    count++;
                }

                rowNumber--;

                for (int i = rowNumber  - 1; i > minCol; i--)
                {
                    arr[i, minCol] = count;
                    count++;
                }

                minCol++;
            }

        }


        private static void FillArray(int[,] arr, int y, int x, int count) // рекурс только до массива 5 х 5
        {
            if (x >= 0 && y >= 0 
                       && x != arr.GetLength(1) 
                       && y != arr.GetLength(0) 
                       && arr[y, x] == 0)
            {
                arr[y, x] = count;
                count++;
                if (x == 0) FillArray(arr, y - 1, x, count);
                FillArray(arr, y, x + 1, count);
                FillArray(arr, y + 1, x, count);
                FillArray(arr, y, x - 1, count);
                FillArray(arr, y - 1, x, count); // для 5 х 5, для 4 х 4 строка не нужна!
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
                    if (lenght == 1)      Console.Write($"  0{arr[i, j]}");
                    else if (lenght == 2) Console.Write($"  {arr[i, j]}");
                    else                  Console.Write($" {arr[i, j]}");
                }
                Console.WriteLine();
            }
        }
    }
}
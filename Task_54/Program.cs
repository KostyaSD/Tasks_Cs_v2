using System;
using System.Globalization;

namespace Task_54
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит
                         по убыванию элементы каждой строки двумерного массива.
                         
                         Например, задан массив:
                         1 4 7 2
                         5 9 2 3
                         8 4 2 4
                         В итоге получается вот такой массив:
                         7 4 2 1
                         9 5 3 2
                         8 4 4 2*/
            
            /*Задача 54.1: Задайте двумерный массив. Напишите программу, которая
                           упорядочит элементы по убыванию (или возрастанию).*/
            
            Console.Write("Введите размер массива m x n:\n" +
                          "m: ");
            int numArrM = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("n: ");
            int numArrN = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[numArrM, numArrN];
            
            FillArray(arr);
            PrintArray(arr);
            
            Console.WriteLine("Сортировка по строкам: ");
            ArrangRowsArr(arr);
            PrintArray(arr);
            
            Console.WriteLine("Сортировка всего массива от большево к меньшему: ");
            ArrangArr(arr);
            PrintArray(arr);
        }

        private static void ArrangArr(int[,] arr)
        {
            int count = 0;
            int[] arr2 = new int[arr.GetLength(0) * arr.GetLength(1)];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr2[count] = arr[i, j];
                    count++;
                }
            }
            Array.Sort(arr2);
            Array.Reverse(arr2);
            count = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = arr2[count];
                    count++;
                }
            }
        }

        private static void ArrangRowsArr(int[,] arr)
        { 
            int[] arr2 = new int[arr.GetLength(1)];
            
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr2[j] = arr[i, j];
                }
                Array.Sort(arr2);
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = arr2[j];
                }
            }
        }

        private static void FillArray(int[,] arr)
        {
            Random random = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = random.Next(-99, 100);
                }
            }
        }
        
        private static void PrintArray(int[,] arr)
        {
            Console.WriteLine("Массив: ");
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
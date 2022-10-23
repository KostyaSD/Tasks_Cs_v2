using System;
using System.Globalization;

namespace Task_56
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая
                         будет находить строку с наименьшей суммой элементов.

                         Например, задан массив:

                         1 4 7 2
                         5 9 2 3
                         8 4 2 4
                         5 2 6 7
                         Программа считает сумму элементов в каждой строке и выдаёт номер строки
                         с наименьшей суммой элементов: 1 строка*/
            
            Console.Write("Введите размер массива m x n:\n" +
                          "m: ");
            int numArrM = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("n: ");
            int numArrN = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[numArrM, numArrN];
            
            FillArray(arr);
            PrintArray(arr);
            EachColumnArr(arr);
        }
        
        private static void EachColumnArr(int[,] arr)
        {
            int numberStr = 0;
            int number = 0;
            
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                number += arr[0, j];
            }
            
            for (int i = 1; i < arr.GetLength(0); i++)
            {
                int count = 0;
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    count += arr[i, j];
                }
                if (number >= count)
                {
                    number = count;
                    numberStr = i;
                }
            }
            Console.WriteLine($"{numberStr + 1} Строка имеет наимешьшую сумму");
        }
        private static void FillArray(int[,] arr)
        {
            Random random = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = random.Next(-10, 21);
                }
            }
        }
        
        private static void PrintArray(int[,] arr)
        {
            Console.WriteLine("Массив: ");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write($"Строка {i + 1}: ");
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
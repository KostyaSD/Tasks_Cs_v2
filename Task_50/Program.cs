using System;
using System.Globalization;

namespace Task_50
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве
                         и возвращает значение этого элемента или же указание, что такого элемента нет.
                        
                         Например, задан массив:
                         1 4 7 2
                         5 9 2 3
                         8 4 2 4
                         [1,7] -> такого элемента в массиве нет*/
            
            const int numArrM = 4;
            const int numArrN = 4;
            
            double[,] arr = new Double[numArrM, numArrN];
            
            FillArray(arr);
            PrintArray(arr);
            
            Console.Write("Введите элемент массива m x n:\n" +
                          "m: ");
            int numM = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("n: ");
            int numN = Convert.ToInt32(Console.ReadLine());

            SearhElement(arr, numM, numN);
        }

        private static void SearhElement(double[,] arr, int numM, int numN)
        {
            try
            {
                Console.WriteLine($"Значения элемента [{numM}, {numN}]: {arr[numM,numN]}");
            }
            catch
            {
                Console.WriteLine($"[{numM}, {numN}] такого элемента в массиве нет");
            }
        }
        
        private static void PrintArray(double[,] arr)
        {
            Console.WriteLine("\nМассив: \n" +
                              " m\\n|    0     1     2     3\n" +
                              " ----------------------------");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write($"  {i} |");
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    var lenght = arr[i, j].ToString(CultureInfo.InvariantCulture).Length;
                    //редактор рекомендует использовать var и CultureInfo.InvariantCulture!
                    if (lenght == 1)      Console.Write($"     {arr[i, j]}");
                    else if (lenght == 2) Console.Write($"    {arr[i, j]}");
                    else if (lenght == 3) Console.Write($"   {arr[i, j]}");
                    else if (lenght == 4) Console.Write($"  {arr[i, j]}");
                    else                  Console.Write($" {arr[i, j]}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
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
using System;

namespace Task_49
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса
                         чётные, и замените эти элементы на их квадраты
             
                         Например, изначально массив            Новый массив будет выглядеть
                         выглядел вот так:                      вот так:
                         1 4 7 2                                1 4 49 2
                         5 9 2 3                                5 9 2 3
                         8 4 2 4                                64 4 4 4 */
            
            int numArrM = 5;
            int numArrN = 4;

            int[,] arr = new int[numArrM, numArrN];

            FillArray(arr);
            PrintArray(arr);
            EvenIndexArr(arr);
            PrintArray(arr);
        }

        private static void EvenIndexArr(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i += 2)
            {
                for (int j = 0; j < arr.GetLength(1); j += 2)
                {
                    arr[i, j] *= arr[i, j];
                }
            }
        }

        private static void PrintArray(int[,] arr)
        {
            Console.WriteLine("\nМассив: \n" +
                              "  |  0   1   2   3\n" +
                              "------------------");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write($"{i} |");
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
                    arr[i, j] = random.Next(-9, 10);
                }
            }
        }
    }
}
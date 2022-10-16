using System;

namespace Task_31
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Задача 31: Задайте массив из 12 элементов, заполните случайными числами из промежутка [-9, 9].
             Найдите сумму отрицательных и положительных элементов массива.
             Например, в массиве[3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29,
             сумма отрицательных равна - 20.*/

            int[] arr = new int[12];
            RandArr(arr);
            PrintArr(arr);
            SumPositivArr(arr);
            SumNegativArr(arr);
        }

        private static void SumPositivArr(int[] arr)
        {
            int sumPos = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 0) sumPos += arr[i];
            }
            Console.WriteLine($"Сумма положительных чисел равна: {sumPos}");
        }

        private static void SumNegativArr(int[] arr)
        {
            int sumNegativ = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0) sumNegativ += arr[i];
            }
            Console.WriteLine($"Сумма отрицательных чисел равна: {sumNegativ}");
        }

        private static void PrintArr(int[] arr)
        {
            Console.Write("Массив: {");
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == arr.Length - 1)
                {
                    Console.WriteLine(arr[i] + "}");
                }
                else
                {
                    Console.Write($"{arr[i]}, ");
                }
            }
        }

        private static void RandArr( int[] arr)
        {
            Random rand = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                arr[i] = rand.Next(-9, 10); //[-9, 10)
            }
        }
    }
}
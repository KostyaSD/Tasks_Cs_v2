using System;

namespace Task_35
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива,
                         значения которых лежат в отрезке [10,99]. 
                         Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
                         
                         [5, 18, 123, 6, 2] -> 1
                         [1, 2, 3, 6, 2] -> 0
                         [10, 11, 12, 13, 14] -> 5*/

            int[] arr = new int[123];

            RandomArr(arr);
            PrintArr(arr);
            CounArr(arr);
        }

        private static void CounArr(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 10 && arr[i] < 100) count++;
            }
            Console.WriteLine($"Количество эллементов: {count}");
        }

        private static void PrintArr(int[] arr)
        {
            Console.Write("Массив: {");
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == arr.Length - 1) Console.WriteLine(arr[i] + "}");
                else Console.Write($"{arr[i]}, ");
            }
        }

        private static void RandomArr(int[] arr)
        {
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(-1000, 1001);
            }
        }
    }
}
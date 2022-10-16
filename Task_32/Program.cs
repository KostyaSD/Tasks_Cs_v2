using System;

namespace Task_32
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Задача 32: Напишите программу замена элементов массива: положительные элементы замените
                         на соответствующие отрицательные, и наоборот.

                        [-4, -8, 8, 2] -> [4, 8, -8, -2]*/

            int[] arr = new int[new Random().Next(4, 13)]; //[4, 13)
            
            RandomArr(arr);
            PrintArr(arr);
            Console.WriteLine("Меняем знаки элементов на противоположные: ");
            RevSignArr(arr);
            PrintArr(arr);
        }

        private static void RevSignArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++) arr[i] *= -1;
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
                if (i == arr.Length - 1) arr[i] = rand.Next(-20, 21);
                else arr[i] = rand.Next(-20, 21);
            }
        }
    }
}
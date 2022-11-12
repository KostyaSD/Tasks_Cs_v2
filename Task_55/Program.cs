using System;
using System.Globalization;

namespace Task_55
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Задача 55: Задайте двумерный массив. Напишите программу, 
                         которая заменяет строки на столбцы. В случае, если это невозможно, 
                         программа должна вывести сообщение для пользователя.*/

            Console.Write("Задайте размер массива [m, n] (размер до 5 х 5):\n" +
                          "Введите число m: ");
            int numM = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Введите число n: ");
            int numN = Convert.ToInt32(Console.ReadLine());

            int[,] arr = new int[numM, numN];
            int[,] arr2 = new int[numN, numM];
            
            FillArray(arr);

            try
            {
                PrintArray(arr);
                RepMatrix(arr);
                PrintArray(arr);
            }
            catch 
            {
                Console.WriteLine("Невозможно!");
            }
        }

        private static void RepMatrix(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0) - 1; i++)
            {
                for (int j = i; j < arr.GetLength(1); j++)
                {
                    int temp = arr[j, i];
                    arr[j, i]= arr[i, j];
                    arr[i, j] = temp;
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
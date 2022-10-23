using System;
using System.Globalization;

namespace Task_51
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Задача 51: Задайте двумерный массив. Найдите сумму элементов,
                         находящихся на главной диагонали*/
            
            Console.Write("Введите размер массива m x n:\n" +
                          "m: ");
            int numArrM = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("n: ");
            int numArrN = Convert.ToInt32(Console.ReadLine());

            int[,] arr = new int[numArrM, numArrN];

            FillArray(arr);
            PrintArray(arr);
            SumMainDiagonalArr(arr);
        }

        private static void SumMainDiagonalArr(int[,] arr)
        {
            int count = 0;
            Console.Write("Сумма ГД: ");
            for (int i = 0; i < arr.GetLength(0); i ++)
            {
                count += arr[i, i];
                if (i != arr.GetLength(0) - 1) Console.Write($"{arr[i, i]} + ");
                else Console.Write($"{arr[i, i]} = ");
            }
            Console.Write(count);
        }

        private static void FillArray(int[,] arr)
        {
            Random random = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = random.Next(-45, 221);
                }
            }
        }
        
        private static void PrintArray(int[,] arr)
        {
            Console.WriteLine("\nМассив: \n");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    var lenght = arr[i, j].ToString(CultureInfo.InvariantCulture).Length;
                    //редактор рекомендует использовать var и CultureInfo.InvariantCulture!
                    if (lenght == 1)      Console.Write($"    {arr[i, j]}");
                    else if (lenght == 2) Console.Write($"   {arr[i, j]}");
                    else if (lenght == 3) Console.Write($"  {arr[i, j]}");
                    //else if (lenght == 4) Console.Write($"  {arr[i, j]}");
                    else                  Console.Write($" {arr[i, j]}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
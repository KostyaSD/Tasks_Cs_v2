using System;

namespace Task_60
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Задача 60: ?Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
                         Напишите программу, которая будет построчно выводить массив, 
                         добавляя индексы каждого элемента.
                         
                         Массив размером 2 x 2 x 2
                         66(0,0,0) 25(0,1,0)
                         34(1,0,0) 41(1,1,0)
                         27(0,0,1) 90(0,1,1)
                         26(1,0,1) 55(1,1,1)*/
            Console.Write("Введите размер матриц m x n x z:\n" +
                          "m: ");
            int numM = Convert.ToInt32(Console.ReadLine());
            Console.Write("n: ");
            int numN = Convert.ToInt32(Console.ReadLine());
            Console.Write("z: ");
            int numX = Convert.ToInt32(Console.ReadLine());

            int[,,] arr = new int[numM, numN, numX];
            
            FillArr(arr);
            PrintArr(arr);
        }

        private static void FillArr(int[,,] arr)
        {
            Random random = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        arr[i, j, k] = random.Next(10, 100);
                    }
                }
            }
        }

        private static void PrintArr(int[,,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        Console.Write($"{arr[i, j, k]}({i}, {j}, {k}) ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
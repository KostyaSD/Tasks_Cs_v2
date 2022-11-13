using System;
using System.Globalization;

namespace Task_58
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Задача 58: ?Задайте две матрицы. Напишите программу, которая будет находить
                         произведение двух матриц.
                         
                         Например, даны 2 матрицы:
                         А В
                         1 4 | 3 5
                         3 5 | 1 2

                         Результирующая матрица будет:
                         С
                         7 13
                         14 25*/

            Console.Write("Введите размер матриц m x n:\n" +
                          "количество строк 1й матрц m: ");
            int numM1 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("количество столбцов 1й матрц и строк 2й матрц: ");
            int numN1 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("количество столбцов 2й матрц: ");
            int numN2 = Convert.ToInt32(Console.ReadLine());
            
            int numFinal;
            numFinal = numM1;
            if (numN2 > numFinal) numFinal = numN2;
            
            int[,] matrixA = new int[numM1, numN1];//[numM1, numN1]
            FillArray(matrixA);
            PrintArray(matrixA, "A");
            int[,] matrixB = new int[numN1, numN2]; //new int[numM2, numN2]
            FillArray(matrixB);
            PrintArray(matrixB, "B");
            int[,] matrixC = new int[numN1, numFinal];
            MultMatrix(matrixA, matrixB, matrixC);
            PrintArray(matrixC, "C");
        }
        
        private static void MultMatrix(int[,] matrixA, int[,] matrixB, int[,] matrixC)
        {
            for (int i = 0; i < matrixC.GetLength(0); i++)
            {
                for (int j = 0; j < matrixC.GetLength(1); j++)
                {
                    for (int k = 0; k < matrixA.GetLength(1); k++)
                    { 
                        matrixC[i,j] += matrixA[i,k] * matrixB[k,j];
                    }
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
                    arr[i, j] = random.Next(-3, 7);
                }
            }
        }

        private static void PrintArray(int[,] arr, string name)
        {
            Console.WriteLine($"Матрица {name}: ");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    var lenght = arr[i, j].ToString(CultureInfo.InvariantCulture).Length;
                    if (lenght == 1) Console.Write($"   {arr[i, j]}");
                    else if (lenght == 2) Console.Write($"  {arr[i, j]}");
                    else Console.Write($" {arr[i, j]}");
                }

                Console.WriteLine();
            }
        }
    }
}
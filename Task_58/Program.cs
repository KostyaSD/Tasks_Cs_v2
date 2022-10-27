using System;
using System.Globalization;

namespace Task_58
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить
                         произведение двух матриц.
                         
                         Например, даны 2 матрицы:
                         А В
                         1 4 | 3 5
                         3 5 | 1 2

                         Результирующая матрица будет:
                         С
                         7 13
                         14 25*/
            
            /*Console.Write("Введите размер массива m x n:\n" +
                          "m: ");
            int numArrM = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("n: ");
            int numArrN = Convert.ToInt32(Console.ReadLine());*/

            int numM1 = 2;
            int numN1 = 2;
            int numM2 = 2;
            int numN2 = 2;
            int numFinal = 0;
            if (numM1 == numN2) numFinal = numM1;
            else if (numM2 == numN1) numFinal = numM2;
            else Console.WriteLine("Матрицы нельзя перемножить");
            int[,] matrixA = new int[numM1, numN1];
            int[,] matrixB = new int[numM2, numN2];
            int[,] matrixC = new int[numFinal, numFinal];
            FillArray(matrixA);
            PrintArray(matrixA, "A");
            FillArray(matrixB);
            PrintArray(matrixB, "B");
            MultMatrix(matrixA, matrixB, matrixC);
            PrintArray(matrixC, "C");
        }

        private static void MultMatrix(int[,] matrixA, int[,] matrixB, int[,] matrixC)
        {
            matrixC[0, 0] = matrixA[0,0] * matrixB[0,0] + matrixA[0, 1] * matrixB[1, 0];
            matrixC[0, 1] = matrixA[0,0] * matrixB[0,1] + matrixA[0, 1] * matrixB[1, 1];
            matrixC[1, 0] = matrixA[1,0] * matrixB[0,0] + matrixA[1, 1] * matrixB[1, 0];
            matrixC[1, 1] = matrixA[1,0] * matrixB[0,1] + matrixA[0, 1] * matrixB[1, 1];
            PrintArray(matrixC, "C");
            for (int i = 0; i < matrixC.GetLength(0); i++)
            {
                for (int j = 0; j < matrixC.GetLength(1); j++)
                {
                    matrixC[i, j] = matrixA[0,0] * matrixB[0,0] + matrixA[0, 1] * matrixB[1, 0];
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
                    arr[i, j] = random.Next(-9, 10);
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
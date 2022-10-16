using System;

namespace Task_38
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Задача 38: Задайте массив вещественных чисел. Найдите разницу между
                         максимальным и минимальным элементов массива.

                        [3 7 22 2 78] -> 76*/
            
            double[] realArr = new Double[new Random().Next(5, 11)];
            RandRealArr(realArr);
            PrintRealArr(realArr);
            DifMaxMinRealArr(realArr);
        }
        
        private static void RandRealArr(double[] realArr) //метод принимает на вход массив double и заполняет его случ. числ.
        {
            Random rand = new Random();
            for (int i = 0; i < realArr.Length; i++)
            {
                realArr[i] = Math.Round(rand.NextDouble() * 100, 2);
            }
        }
        
        private static void PrintRealArr(Double[] arr) //метода принимает на вход массив double и выводит его в консоль
        {
            Console.Write("Массив: {");
            for (int i = 0; i < arr.Length; i++)
            {
                if(i == arr.Length - 1) Console.WriteLine(arr[i] + "}");
                else Console.Write($"{arr[i]}, ");
            }
        }
        
        private static void DifMaxMinRealArr(double[] realArr) //метод принимает на вход массив и находит разницу Max, Min
        {
            Double max = realArr[0];
            Double min = realArr[0];

            for (int i = 0; i < realArr.Length; i++)
            {
                if (realArr[i] > max) max = realArr[i];
                else if (realArr[i] < min) min = realArr[i];
            }

            Double dif = max - min;
            Console.WriteLine($"Разница между Max и Min: {dif}");
        }
    }
}
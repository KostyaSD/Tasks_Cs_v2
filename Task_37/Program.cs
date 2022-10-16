using System;

namespace Task_37
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый 
                         и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
                         
                         [1 2 3 4 5] -> 5 8 3
                         [6 7 3 6] -> 36 21*/
            
            int[] arr = new int[new Random().Next(4, 10)];
            
            RandArr(arr);
            PrintArr(arr);
            ProductNumber(arr);
        }

        private static void PrintArr(int[] arr)
        {
            Console.Write("Массив: {");
            for (int i = 0; i < arr.Length; i++)
            {
                if(i == arr.Length - 1) Console.WriteLine(arr[i] + "}");
                else Console.Write($"{arr[i]}, ");
            }
        }

        private static void RandArr(int[] arr)
        {
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(2, 20);
            }
        }

        private static void ProductNumber(int[] arr)
        {
            int n;
            if (arr.Length % 2 == 0) n = arr.Length / 2;
            else n = (arr.Length / 2) + 1;
            int[] arrey = new int[n];
            for (int i = 0; i < arr.Length / 2; i++)
            {
                arrey[i] = arr[i] * arr[arr.Length - 1 - i];
            }
            if (arr.Length % 2 != 0) arrey[arrey.Length - 1] = arr[(arr.Length / 2)];
            PrintArr(arrey);
        }
    }
}
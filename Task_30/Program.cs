using System;

namespace Task_30
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Задача 30: Напишите программу, которая выводит массив из 8 элементов,
             заполняющий нулями и единицами в случайном порядке.

             {1,0,1,1,0,1,0,0}*/
            
            Random rand = new Random();
            int[] arr = new int[8];
            Console.Write("Ответ: {");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(0, 2);
                if (i == arr.Length - 1) Console.Write(arr[i] + "}");
                else Console.Write($"{arr[i]}, ");
            }
        }
    }
}
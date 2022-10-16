using System;

namespace Task_36
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Задача 36: Задайте одномерный массив, заполненный случайными числами.
             Найдите сумму элементов, стоящих на нечётных позициях.

                [3, 7, 23, 12] -> 19
                [-4, -6, 89, 6] -> 0*/
            
            int[] arr = new int[new Random().Next(5, 11)];
            RandArr(arr);
            PrintArr(arr);
            PrintSumOddPos(arr);
        }
        
        private static void RandArr(int[] arr) //метод принимает на вход массив int и заполняет его случ. числами
        {
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(-99, 100);
            }
        }
        
        private static void PrintArr(int[] arr) //метода принимает на вход массив int и выводит его в консоль
        {
            Console.Write("Массив: {");
            for (int i = 0; i < arr.Length; i++)
            {
                if(i == arr.Length - 1) Console.WriteLine(arr[i] + "}");
                else Console.Write($"{arr[i]}, ");
            }
        }
        
        private static void PrintSumOddPos(int[] arr) // метод прин. масс и выводит в консл. сумму элемент на нечет поз.
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 != 0)
                {
                    sum += arr[i];
                }
            }
            Console.WriteLine($"Сумма элементов на нечетных позициях: {sum}");
        }
    }
}
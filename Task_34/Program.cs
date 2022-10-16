using System;

namespace Task_34
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите
                         программу, которая покажет количество чётных чисел в массиве.

                        [345, 897, 568, 234] -> 2*/
            
            int[] arr = new int[new Random().Next(5, 11)];
            RandThrArr(arr);
            PrintArr(arr);
            PrintEvenSum(arr);
        }
        
        private static void RandThrArr(int[] arr) //метод принимает на вход массив int и заполняет его полож. трех.знач числами
        {
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(100, 1000);
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
        
        private static void PrintEvenSum(int[] arr) //метод принимает массив и выводит в консоль кол. пол. чисел
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    sum++;
                }
            }
            Console.WriteLine($"Количество четных чисел: {sum}");
        }
    }
}
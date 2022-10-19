using System;

namespace Task_39
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Задача 39: Напишите программу, которая перевернёт одномерный массив
                         (последний элемент будет на первом месте, а первый - на последнем и т.д.)
                         
                         [1 2 3 4 5] -> [5 4 3 2 1]
                         [6 7 3 6] -> [6 3 7 6]*/
            
            Console.Write("Введите длину массива: ");
            
            int countArr = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[countArr];
            
            RandomArray(arr, -20, 21); // заполнение массива от [-20; 21).
            PrintArr(arr); // вывод массива
            ReversArr(arr); //разворот массива
            PrintArr(arr); // вывод массива
        }
        
        private static void ReversArr(int[] arr)
        {
            int count;
            for (int i = 0; i < arr.Length / 2; i++)
            {
                count = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - i - 1] = count;
            }
        }
        
        private static void PrintArr(int[] arr)
        {
            Console.Write("Массив: {");
            for (int i = 0; i < arr.Length; i++)
            {
                if(i != arr.Length - 1) Console.Write($"{arr[i]}, ");
                else Console.WriteLine(arr[i] + "}");
            }
        }
        
        private static void RandomArray(int[] arr, int min, int max)
        {
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(min, max);
            }
        }
    }
}
using System;

namespace Final_project
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Итоговая задача: Напишите программу, которая из имеющегося массива строк формирует массив из строк,
                               длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с 
                               клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется
                               пользоваться коллекциями, лучше обойтись исключительно массивами.

                               ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
                               ["1234", "1567", "-2", "computer science"] -> ["-2"]
                               ["Russia", "Denmark", "Kazan", "computer science"] -> []*/
            
            string[] inputArr = GetString();
            string[] outputArr = SearchLess(inputArr, 3);
            
            Solution(inputArr, outputArr);
        }

        private static void Solution(string[] inputArr, string[] outputArr)
        {
            PrintArray(inputArr);
            Console.Write(" -> ");
            PrintArray(outputArr);
        }

        private static void PrintArray(string[] arr)
        {
            Console.Write("[");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"\"{arr[i]}\"");
                if(i != arr.Length - 1) Console.Write($", ");
            }
            Console.Write("]");
        }

        private static string[] GetString()
        {
            Console.WriteLine("Введите значения через запятую: ");
            return Console.ReadLine()?.Split(',');
        }

        private static string[] SearchLess(string[] inputArr, int n)
        {
            string[] result = new string[GetLength(inputArr, n)];
            for (int i = 0, j = 0; i < inputArr.Length; i++)
            {
                if (inputArr[i].Length <= n)
                {
                    result[j] = inputArr[i];
                    j++;
                }
            }
            return result;
        }

        private static int GetLength(string[] arr, int len)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length <= len)
                    count++;
            }
            return count;
        }
    }
}
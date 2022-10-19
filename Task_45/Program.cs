using System;

namespace Task_45
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Задача 45: Напишите программу, которая будет создавать копию заданного
             массива с помощью поэлементного копирования*/

            int[] array1 = new int[8];
            int[] array2 = new int[8];

            randomFilling(array1, 0, 100);
            copy(array1, array2);
            PrintArr(array1);
            PrintArr(array2);

            void copy(int[] arr, int[] arr2)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    arr2[i] = arr[i];
                }
            }

            void randomFilling(int[] arr, int min, int max)
            {
                Random random = new Random();
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = random.Next(min, max);
                }
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

        /*
        int[] array1 = new Int32[8];
        int[] array2 = new Int32[8];

        randomFilling(array1, 0, 100);
        arrayOutput(array1);
        copy(array1, array2);
        arrayOutput(array2);

        void copy(int[] array1, int[] array2)
        {
            for (int i = 0; i < array1.Length; i++)
            {
                array2[i] = array1[i];
            }
        }


        void randomFilling(int[] arr, int min, int max)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new Random().Next(min, max);
            }
        }

        void arrayOutput(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}");
                if (i < (arr.Length-1)) Console.Write($", ");
    
            }
            Console.WriteLine(" ");
        }
        */
        }
}
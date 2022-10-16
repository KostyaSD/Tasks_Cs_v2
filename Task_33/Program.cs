using System;

namespace Task_33
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует
                         ли заданное число в массиве.
                         
                         4; массив [6, 7, 19, 345, 3] -> нет
                         -3; массив [6, 7, 19, 345, 3] -> да*/

            int[] arr = { 6, 7, 19, 345, 3 };

            Console.Write("Введите число: ");
            int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));

            SearNumber(num, arr);

        }

        private static void SearNumber(int num, int[] arr)
        {
            int result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num) result = 1;
            }
            if (result == 1) Console.WriteLine("Да");
            else Console.WriteLine("Нет");
        }
    }
}
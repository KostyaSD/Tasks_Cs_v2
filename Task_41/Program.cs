using System;

namespace Task_41
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Задача 41: Дз. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел
                         больше 0 ввёл пользователь.

                         0, 7, 8, -2, -2 -> 2
                         1, -7, 567, 89, 223-> 3*/
            
            Console.Write("Введите количество цифр для ввода: ");
            int countArr = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[countArr];
            InputNumArr(arr);
            PrintArr(arr);
            HowNumMoreZero(arr);
        }

        private static void HowNumMoreZero(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0) count++;
            }
            Console.WriteLine($"Пользователь ввел чисел больше 0: {count}");
        }

        private static void InputNumArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Введите {i + 1} число: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
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
    }
}
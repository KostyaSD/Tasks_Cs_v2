using System;

namespace Task_29
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Задача 29: Напишите программу, которая задаёт массив произвольной длины, заполняет
             произвольными элементами и выводит их на экран. Длину массива и элементы
             массива можно задать рандомно или попросить пользователя ввести в консоли.

             1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
             6, 1, 33 -> [6, 1, 33]*/ 
            
            Console.Write("Выберите действие:\n" +
                          "1. Задать длину массива вручную\n" +
                          "2. Задать длину массива автоматически\n" +
                          "Ваш выбор: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Random rand = new Random();
            int[] arr = new int[0];
            switch (num)
            {
                case 1:
                    Console.Write("Введите длину массива: ");
                    num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
                    Array.Resize(ref arr, num);
                    Console.WriteLine($"Длина массива: {arr.Length}");
                    break;
                case 2:
                    Array.Resize(ref arr, rand.Next(4, 21));
                    Console.WriteLine($"Длина массива: {arr.Length}");
                    break;
                default:
                    Console.Write("Что-то пошло не так! надо было выбрать 1 либо 2\n" +
                                  "Миссия провалена!");
                    break;
            }
            Console.Write("Выберите действие:\n" +
                          "1. Заполнить массив вручную\n" +
                          "2. Заполнить массив автоматически\n" +
                          "Ваш выбор: ");
            num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    for (int i = 0; i < arr.Length; i++)
                    {
                        Console.Write($"Введите эллемент {i}: ");
                        arr[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.Write("Ответ: Массив {");
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (i == arr.Length - 1) Console.Write(arr[i] + "}");
                        else Console.Write($"{arr[i]}, ");
                    }
                    break;
                case 2:
                    Console.Write("Ответ: Массив {");
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] = rand.Next(0, 200);
                        if (i == arr.Length - 1) Console.Write(arr[i] + "}");
                        else Console.Write($"{arr[i]}, ");
                    }
                    break;
                default:
                    Console.Write("Что-то пошло не так! надо было выбрать 1 либо 2\n" +
                                  "Миссия провалена!");
                    break;
            }
        }
    }
}
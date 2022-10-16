using System;

namespace Task_27
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

             452 -> 11
             82 -> 10
             9012 -> 12*/
            
            Console.Write("Введите число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            // 1 вариант решения: 
            while (num != 0)
            {
                count += num % 10;
                num /= 10;
            }
            Console.WriteLine($"Ответ: {count}");
            // 2 вариант решения:
            /*        int lenght = num1.ToString().Length;
                    char[] text = num1.ToString().ToCharArray();
                    for (int i = 0; i < lenght; i++)
                    {
                        count += Convert.ToInt32(text[i].ToString());
                    }
                    Console.Write($"Ответ: {count}");*/
        }
    }
}
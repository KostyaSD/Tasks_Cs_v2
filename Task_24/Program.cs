using System;

namespace Task_24
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Задача 24: Напишите программу, которая принимает на вход число (А)
             и выдаёт сумму чисел от 1 до А.
             7 -> 28
             4 -> 10
             8 -> 36*/
            
            Console.Write("Введите число А: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            if (num > 1)
            {
                for (int i = 1; i <= num; i++)
                {
                    sum += i;
                }
                Console.Write($"Ответ: Сумма чисел от 1 до {num} = {sum}");
            }
            else Console.Write("Ответ: Прочитайте внимательно условие \"от 1\", это значит первая цифра 2!");
        }
    }
}
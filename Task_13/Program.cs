using System;

namespace Task_13
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Задача 13: Напишите программу, которая выводит третью цифру заданного числа
             или сообщает, что третьей цифры нет.

             645 -> 5
             78 -> третьей цифры нет
             32679 -> 6*/
            
            Console.Write("Введите число: ");
            int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
            if (num > 99)
            {
                string textNumber = num.ToString();
                int lenght = textNumber.Length; //int lenght = (int)Math.Log10(num) + 1;
                num = num / (int)Math.Pow(10, lenght - 3) % 10;
                Console.WriteLine("Ответ: Третья цифра числа: " + num);
            }
            else
            {
                Console.WriteLine("Ответ: Третьей цифры нет");
            }
        }
    }
}
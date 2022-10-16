using System;

namespace Task_3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            /*Задача 3: Напишите программу, которая будет выдавать название
                        дня недели по заданному номеру.
        
                        3 -> max = Среда
                        5 -> max = Пятница*/
            
            Console.Write("Введите номер дня недели: ");
            int number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case 1:
                    Console.WriteLine("Ответ: Понедельник");
                    break;
                case 2:
                    Console.WriteLine("Ответ: Вторник");
                    break;
                case 3:
                    Console.WriteLine("Ответ: Среда");
                    break;
                case 4:
                    Console.WriteLine("Ответ: Четверг");
                    break;
                case 5:
                    Console.WriteLine("Ответ: Пятница");
                    break;
                case 6:
                    Console.WriteLine("Ответ: Суббота");
                    break;
                case 7:
                    Console.WriteLine("Ответ: Воскресенье");
                    break;
                default:
                    Console.WriteLine("Такого дня недели нет!");
                    break;
            }
        }
    }
}
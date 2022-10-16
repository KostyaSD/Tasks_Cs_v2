using System;

namespace Task_17
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Задача 17: Напишите программу, которая принимает на вход координаты точки(X, Y),
             причем X != 0 и Y != 0 и выдаёт номер четверти плоскости,
             в которой находится эта точка.

                   y^
                  2 | 1
                --- | --- >x
                  3 | 4*/

            Console.Write("Введите координату x: ");
            int numA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату y: ");
            int numB = Convert.ToInt32(Console.ReadLine());
            if (numA > 0 && numB > 0) Console.Write("Ответ: Точка находится в ПЕРВОЙ четверти.");
            else if (numA < 0 && numB > 0) Console.Write("Ответ: Точка находится во ВТОРОЙ четверти.");
            else if (numA < 0 && numB < 0) Console.Write("Ответ: Точка находится в ТРЕТЬЕЙ четверти.");
            else if (numA > 0 && numB < 0) Console.Write("Ответ: Точка находится в ЧЕТВЕРТОЙ четверти.");
            else Console.Write("Ответ: Точка находится на оси координат.");
        }
    }
}
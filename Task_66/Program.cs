using System;

namespace Task_66
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Задача 66:  Задайте значения M и N. Напишите программу, которая найдёт
                          сумму натуральных элементов в промежутке от M до N.

                          M = 1; N = 15 -> 120
                          M = 4; N = 8. -> 30*/
            
            Console.WriteLine("Введите начальное число M:");
            int numM = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите начальное число M:");
            int numN = int.Parse(Console.ReadLine());
            
            GetSumNaturNum(numM, numN, 0);
        }

        private static void GetSumNaturNum(int numM, int numN, int sum)
        {
            if (numM > numN) 
            {
                Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
                return;
            }
            sum += numM++;
            GetSumNaturNum(numM, numN, sum);
        }
    }
}
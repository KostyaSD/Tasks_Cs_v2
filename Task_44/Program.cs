using System;

namespace Task_44
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Задача 44: Не использую рекурсию, выведите первые N
                         чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1
                         Если N = 5 -> 0 1 1 2 3
                         Если N = 3 -> 0 1 1
                         Если N = 7 -> 0 1 1 2 3 5 8*/

            int fib = Convert.ToInt32(Console.ReadLine());
            
            int first = 0;
            int second = 1;
            int next = 0;
            Console.Write("0 1 ");
            for (int i = 1; i < fib - 1; i++)
            {
                next = first + second;
                Console.Write(next + " ");
                first = second;
                second = next;
            }
        }
    }
}
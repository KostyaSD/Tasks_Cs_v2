using System;

namespace Task_42
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
            Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
                       45 -> 101101
                       3  -> 11
                       2  -> 10
            */
            int x = 3;
            //Console.WriteLine(Convert.ToString(x, 2));
            Binar(x);
        }
        
        private static void Binar(int a)
        {
            string text = "";
            while (a != 0)
            {
                text += a % 2;
                a = a/2;
            }
            char[] arr = text.ToCharArray();
            Array.Reverse(arr);
            Console.WriteLine(arr);
        }
        
        /*Console.WriteLine("Введите число");

        int number = Convert.ToInt32(Console.ReadLine());

        string count = null;
            while (number != 0)
        {
            count += number % 2;
            number /= 2;
        }

        for (int i = count.Length - 1; i >= 0; i--)
        {
            Console.Write(count[i]);
        }*/

    }
}
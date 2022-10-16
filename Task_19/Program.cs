using System;

namespace Task_19
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Задача 19: Напишите программу, которая принимает на вход пятизначное число
             и проверяет, является ли оно палиндромом.

             14212 -> нет
             12821 -> да
             23432 -> да*/
            
            Console.Write("Введите число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            string textNumber = num.ToString();
            int lenght = textNumber.Length;
            int result = 0;
            for (int i = 0; i <= lenght / 2; i++)
            {
                /*if (textNumber[i] == textNumber[lenght - 1 - i])
                  {
                      //Console.WriteLine($"цифры {textNumber[i]} и {textNumber[lenght - 1 - i]} совпали");
                  }
                  else
                  {
                      //Console.WriteLine($"цифры {textNumber[i]} и {textNumber[lenght - 1 - i]} не совпали - число не полиндром");
                      result = 1;
                      break;
                  }*/
                if (textNumber[i] != textNumber[lenght - 1 - i])
                {
                    result = 1;
                    break;
                }
            }
            if (result == 0) Console.WriteLine("Ответ: Число полиндром");
            else Console.WriteLine("Ответ: Число не полиндром");
        }
    }
}
﻿using System.Text;

namespace Basic_05_2_NumberFormatException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            bool flag;
            double number = 0;

            Console.WriteLine("Введіть число: ");
            do
            {
                flag = true;
                try
                {
                    number = Convert.ToDouble(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Некоректне значення: " + ex.Message);
                    flag = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    flag = false;
                }
                finally
                {
                    if(!flag)
                    {
                        Console.WriteLine("Спробуйте ще раз ввести число: ");
                    }
                }
            } while (!flag);
            Console.WriteLine($"Введене число: {number} {Environment.NewLine}");





            //from https://learn.microsoft.com/ru-ru/dotnet/standard/base-types/parsing-numeric
            string value;
            // Define a string of basic Latin digits 1-5.
            value = "\u0031\u0032\u0033\u0034\u0035";
            ParseDigits(value);

            // Define a string of Fullwidth digits 1-5.
            value = "\uFF11\uFF12\uFF13\uFF14\uFF15";
            ParseDigits(value);

            // Define a string of Arabic-Indic digits 1-5.
            value = "\u0661\u0662\u0663\u0664\u0665";
            ParseDigits(value);

            // Define a string of Bangla digits 1-5.
            value = "\u09e7\u09e8\u09e9\u09ea\u09eb";
            ParseDigits(value);
        }
        static void ParseDigits(string value)
        {
            try
            {
                int number = Int32.Parse(value);
                Console.WriteLine($"'{value}' --> {number}");
            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse '{value}'.");
            }
        }
    }
}

//Напишіть програму, яка зчитує число з рядка. Якщо введене значення не є числом,
//виведіть повідомлення про помилку.
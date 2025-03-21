using System;
using System.Text;

namespace ExceptionHandlingExample
{
    public class Calculator
    {
        public static double Calculate(double num1, double num2, char operation)
        {
            // код писати тут
            switch (operation)
            {
                case '+':
                    return num1 + num2;
                case '-':
                    return num1 - num2;
                case '*':
                    return num1 * num2;
                case '/':
                    //try
                    //{
                    //    return num1 / num2;//ПОВЕРТАЄ НЕСКІНЧЕННІСТЬ ПРИ ДІЛЕННІ НА НУЛЬ!!!
                    //}
                    //catch (DivideByZeroException ex)
                    //{
                    //    Console.WriteLine(ex.Message);
                    //}
                    //break;

                    if (num2 == 0)//за відсутності помилки у консолі при діленні на нуль
                    {
                        throw new DivideByZeroException("Помилка: Ділення на нуль заборонено!");
                    }
                    else
                    {
                        return num1 / num2;//ПОВЕРТАЄ НЕСКІНЧЕННІСТЬ ПРИ ДІЛЕННІ НА НУЛЬ!!!
                    }
                default:
                    return 0;
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            // код писати тут
            bool flag;//For input correct data
            double num1 = 0;
            double num2 = 0;
            char operation = '_';

            //Input first number from user
            do
            {
                flag = true;
                try
                {
                    Console.WriteLine("Введіть перше число: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Некоректне значення");
                    flag = false;
                }
            } while (!flag);

            //Input second number from user
            do
            {
                flag = true;
                try
                {
                    Console.WriteLine("Введіть друге число: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Некоректне значення");
                    flag = false;
                }
            } while (!flag);

            //Input operation from user
            do
            {
                try
                {
                    flag = true;
                    Console.WriteLine("Оберіть операцію (+, -, *, /): ");
                    operation = Convert.ToChar(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Некоректне значення");
                    flag = false;
                }
                if (operation == '+' || operation == '-' || operation == '*' || operation == '/')
                {
                    flag = true;
                }
                else
                {
                    flag = false;//Повторно, якщо було введено символ, але не з чотирьох передбачених
                }
            } while (!flag);

            //Помилка очікувалась при операції ділення на нуль, але замість неї знак нескінченності і корректна робота програми,
            //тому блок try-catch тут
            try
            {
                Console.WriteLine($"{num1} {operation} {num2} = {Calculator.Calculate(num1, num2, operation)}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
using System.Text;

namespace Basic_05_1_exception_divide_by_zero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            bool flag;//For input correct data
            double num1 = 0;
            double num2 = 0;

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

            //Cause divide by zero return infinite, use own method in try-catch
            try
            {
                Console.WriteLine($"{num1} / {num2} = {Calculator.Calculate(num1, num2)}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    //Create like the bonus task
    public class Calculator
    {
        public static double Calculate(double num1, double num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException("помилка: Ділення на ноль!");
            }
            else
            {
                return num1 / num2;
            }
        }
    }
}
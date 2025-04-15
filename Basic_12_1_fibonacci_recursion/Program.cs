using System.Text;

namespace Basic_12_1_fibonacci_recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            char continueChar;
            int number = 0;
            do
            {
                Console.Clear();
                Console.Write("Введіть номер числа із послідовності Фібоначчі: ");
                try
                {
                    number = Convert.ToInt32(Console.ReadLine());
                    if(number > 0)
                    {
                        Console.WriteLine($"{NumberFibonacci.NumberFibonacciMethod(number)} за номером {number} у послідовності Фібоначчі");
                    }
                    else
                    {
                        Console.WriteLine("negative number");
                    }
                }
                catch
                {
                    Console.WriteLine("введіть число");
                }
                Console.Write("Continue (Yes - y)?: ");
                continueChar = Console.ReadKey().KeyChar;
            } while (continueChar == 'y' || continueChar == 'у');
        }
    }
}

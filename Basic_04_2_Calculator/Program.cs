using System.Text;

namespace Basic_04_2_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ukrainian in Console
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            //Get numbers and type of act from user
            Console.Write("Введіть перше ціле число: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введіть друге ціле число: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введіть знак (+, -, *, /) аріфметичної дії: ");
            char symbol = Convert.ToChar(Console.ReadLine());

            double result = 0; //Type double for division
            bool flagOut = true;
            //Using "switch" for operation
            switch (symbol)
            {
                case '+':
                    result = number1 + number2;
                    break;
                case '-':
                    result = number1 - number2;
                    break;
                case '*':
                    result = number1 * number2;
                    break;
                case '/':
                    if (number2 != 0)
                    {
                        result = number1 / (double)number2;
                    }
                    else
                    {
                        Console.WriteLine("Ділення на ноль викликає помилку!!!");
                        flagOut = false;
                    }
                    break;
                default:
                    Console.WriteLine("Вказана дія не передбачена даною програмою");
                    flagOut = false;
                    break;
            }

            if (flagOut)
            {
                Console.WriteLine($"{number1} {symbol} {number2} = {result}");
            }
        }
    }
}

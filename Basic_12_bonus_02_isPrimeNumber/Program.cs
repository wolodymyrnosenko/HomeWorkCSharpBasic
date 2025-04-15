//Створити функцію, що буде перевіряти, чи є задане число простим чи ні.
//Про те, що таке прості числа, написано тут.
namespace Basic_12_bonus_02_isPrimeNumber
{
    internal class Program
    {
        public static void Main() 
        {
            Console.WriteLine(IsPrime(4));
            Console.WriteLine(IsPrime(3));
            Console.WriteLine(IsPrime(-1));
            Console.WriteLine(IsPrime(0));

        }
        public static bool IsPrime(int number)
        {
            // Писати код тут
            if(number <= 0)
            {
                return false;
            }
            else
            {
                for(int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}

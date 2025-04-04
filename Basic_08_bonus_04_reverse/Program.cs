//Треба розвернути задану строку у зворотньому порядку.
//Тобто перший символ має стати останнім, а останній - першим.
namespace Basic_08_bonus_04_reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        // Метод для реверсу
        public static string ReverseString(string input)
        {
            // Писати код тут
            char[] reverse = new char[input.Length];
            for(int i = 0; i < input.Length; i++)
            {
                reverse[i] = input[input.Length - 1 - i];
            }
            return new string(reverse);
        }

    }
}

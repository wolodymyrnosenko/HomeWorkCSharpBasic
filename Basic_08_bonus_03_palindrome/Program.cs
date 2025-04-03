//Враховуючи, що строка по суті є масивом символів, перевірити,
//чи є введена строка паліндромом. Пуста строка не є паліндромом.
//Паліндром — слово, набір символів, або словосполучення, що однаково
//читається в обох напрямках (зліва направо та справа наліво).
//Наприклад, такі слова як око, дід, радар, ротатор є паліндромами.

namespace Basic_08_bonus_03_palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        // Метод для встанолення паліндрому
        public static bool IsPalindrome(string input)
        {
            // Тут повинен бути ваш код
            if (input.Length == 0)
            {
                return false;
            }
            for (int i = 0; i < (input.Length / 2); i++)
            {
                if (input[i] != input[input.Length-1-i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}

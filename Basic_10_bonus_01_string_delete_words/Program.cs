//Створіть консольну програму на C#, яка обробляє великий текстовий рядок.
//Вам потрібно видалити всі слова, які мають менше ніж 3 символи, і вивести результат на екран.
//При цьому використовуйте StringBuilder для оптимізації роботи з рядками.
//Опис:
//Введіть великий текстовий рядок з консолі.
//Розділіть рядок на окремі слова за допомогою пробілів або інших розділових знаків.
//Видаліть всі слова, які мають менше ніж 3 символи.
//Виведіть залишені слова на екран.
using System.Text;

namespace Basic_10_bonus_01_string_delete_words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Введіть великий текстовий рядок:");
            string inputText = Console.ReadLine();

            string result = TextProcessor.FilterWords(inputText);

            Console.WriteLine("Результат:");
            Console.WriteLine(result);
        }
    }

    public class TextProcessor
    {
        public static string FilterWords(string inputText)
        {
            try
            {
                // код писати тут
                char[] separators = new char[] { ' ', ',', '.', ';', ':', '-', '\"', '\\', '!', '?' };
                string[] str = inputText.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                string text = string.Empty;
                foreach (var st in str)
                {
                    if(st.Length >= 3)
                    {
                        text += $"{st} ";
                    }
                }
                return text;
            }
            catch (Exception ex)
            {
                return "Помилка: " + ex.Message;
            }
        }
    }
}

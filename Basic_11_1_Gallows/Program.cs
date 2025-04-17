using System.Reflection.Metadata;
using System.Text;

namespace Basic_11_1_Gallows
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            string guessWord = GuessWord.RandomWord().ToLower();
            int countAttempt = guessWord.Length;
            string userWord = new string('*', guessWord.Length);
            string hello = "Вітаємо! Спробуйте вгадати зашифроване слово!";
            Console.WriteLine(hello);

            //Console.WriteLine(guessWord.PadLeft(hello.Length, ' '));//For testing GUESSED WORD

            Console.WriteLine($"Кількість літер у слові: {guessWord.Length}");
            Console.WriteLine($"Кількість можливих невірних спроб: {countAttempt}");
            do
            {
                Console.WriteLine(userWord.PadLeft(hello.Length, ' '));
                Console.Write("Введіть вашу літеру: ");
                char inputSymbol = Console.ReadKey().KeyChar;
                if(guessWord.Contains(inputSymbol))
                {
                    Console.WriteLine($"{Environment.NewLine}Така літера є у слові! Позиція літери: {LetterIndex(inputSymbol, guessWord, ref userWord)}");
                }
                else
                {
                    Console.WriteLine($"{Environment.NewLine}Такої літери немає! Залишилось спроб: {--countAttempt}");

                }
            } while (!isGameover(countAttempt, guessWord, userWord));
            Console.WriteLine("Дякуємо за гру.");
        }
        public static StringBuilder LetterIndex(char inputSymbol, string guessWord, ref string userWord)
        {
            char[] tempWord = userWord.ToCharArray();//Create array to use in loop, cause userWord[i] only read
            StringBuilder str = new StringBuilder();
            string firstWithoutPoint = string.Empty;
            for (int i = 0; i < guessWord.Length; i++)
            {
                if (guessWord[i] == inputSymbol)
                {
                    str = str.Append(firstWithoutPoint + (i + 1));
                    firstWithoutPoint = ", ";
                    tempWord[i] = guessWord[i];
                }
            }
            userWord = new string(tempWord);//Change ref_userWord to output in console
            return str;
        }
        static bool isGameover(int count, string word, string usWord)
        {
            if (word.Equals(usWord))
            {
                Console.WriteLine($"Вітаємо, ви вгадали слово! Зашифроване слово: {word}.");
            }
            return count == 0 || word.Equals(usWord);
        }
    }
}

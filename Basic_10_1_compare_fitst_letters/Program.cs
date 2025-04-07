using System.Text;

namespace Basic_10_1_compare_fitst_letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.Write("Введіть ім'я та прізвище: ");
            string complexName = Console.ReadLine();
            CompareFirstLetters(complexName);
        }
        public static void CompareFirstLetters(string txt)
        {
            int index = txt.IndexOf(" ");
            Console.WriteLine(index);
            var test = txt.Split(" ");
        }
    }
}

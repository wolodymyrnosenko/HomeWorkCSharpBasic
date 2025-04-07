using System.Text;

namespace Basic_10_3_delete_spaces_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.Write("Введіть текст: ");
            string text = Console.ReadLine();
            Console.WriteLine($"Введений текст без пробілів: {DeleteSpacesInText(text)}");

        }
        public static String DeleteSpacesInText(string txt)
        {
            return txt.Replace(" ", "");
        }
    }
}

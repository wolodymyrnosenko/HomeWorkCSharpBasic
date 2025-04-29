using System.Text;

namespace Basic_16_1_CopyTxtFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.Write("Введіть шлях до вихідного файлу: ");
            string sourcePath = Console.ReadLine();
            Console.Write("Введіть шлях до файлу, в якій потрібно скопіювати дані: ");
            string destinationPath = Console.ReadLine();
            try
            {
                new FileCopier(sourcePath, destinationPath).Copy();
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
        }
    }
}

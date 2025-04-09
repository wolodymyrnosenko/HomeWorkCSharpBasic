using System.Text;

namespace Basic_09_1_Arrays_2
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            string[] menuItems = {"0 - Завершення програми",
                                "1 - Другий найбільший елемент у масиві",
                                "2 - ",
                                "3 - ",
                                "4 - "};
            int userChoice = -1;
            do
            {
                Console.Clear();
                foreach (var menuItem in menuItems)
                {
                    Console.WriteLine(menuItem);
                }
                Console.Write("Введіть номер за списком: ");
                try
                {
                    userChoice = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Введіть цифру");
                    Console.ReadLine();
                    continue;
                }
                switch (userChoice)
                {
                    case 1:
                        SecondMaxAraryElement.SecondMaxAraryElementFunction(7, 9);
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;

                }
            } while (userChoice != 0);
        }
    }
}

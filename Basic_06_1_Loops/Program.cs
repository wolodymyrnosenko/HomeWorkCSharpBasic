using System.Text;

namespace Basic_06_1_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            string[] menuItems = {"0 - Завершення програми",
                                "1 - Обчислення середнього заробітку",
                                "2 - Побудова графіку зірочками",
                                "3 - Генерація простих чисел",
                                "4 - Перевірка паролю",
                                "5 - Генерація фібоначчівської послідовності",
                                "6 - Калькулятор оплати праці за годину"};
            int userChoice = -1;
            do
            {
                Console.Clear();
                foreach(var menuItem in menuItems)
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
                switch(userChoice)
                {
                    case 1:
                        AverageSalary.averageSalary();
                        break;
                    case 2:
                        LinesUsingStars.linesUsingStars();
                        break;
                    case 3:
                        JustNumber.justNumber();
                        break;
                    case 4:
                        CheckPassword.checkPassword();
                        break;
                    case 5:
                        FibonacciNumbers.fibonacciNumbers();
                        break;
                    case 6:
                        PayForHour.payForHour();
                        break;
                }
            }while(userChoice != 0);
        }
    }
}

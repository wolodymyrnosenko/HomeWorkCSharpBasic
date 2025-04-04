using System.Text;

namespace Basic_08_1_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            string[] menuItems = {"0 - Завершення програми",
                                "1 - Виведення парних індексів масиву",
                                "2 - Сума елементів масиву із п.1",
                                "3 - Таблиця множення",
                                "4 - Максимум і мінімум у масиві",
                                "5 - День тижня (за допомогою enum)"};
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
                        NumersOnEvenIndex.NumbersOnEvenIndexFunction();
                        break;
                    case 2:
                        SumOfElements.SumOfElementsFunction();
                        break;
                    case 3:
                        MultiplyTable.MultiplyTableFunction();
                        break;
                    case 4:
                        MaxAndMin.MaxAndMinFunction();
                        break;
                    case 5:
                        DayOfWeekEnum.DayOfWeekEnumFunction();
                        break;
                }
            } while (userChoice != 0);
        }

    }
}

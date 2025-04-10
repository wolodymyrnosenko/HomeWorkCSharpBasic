using System.Text;

namespace Basic_09_1_Arrays_2_algorythms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            string[] menuItems = {"0 - Завершення програми",
                                "1 - Другий найбільший елемент у масиві",
                                "2 - Сортування двовимірного масиву за зростанням",
                                "3 - Видалити елемент з масиву за вказаним індексом",
                                "4 - Сума елементів по діагоналі у двовимірному масиві"};
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
                        SecondMaxAraryElement.SecondMaxArrayElementFunction(5, 8);
                        break;
                    case 2:
                        SortArray.SortArrayFunction(5, 8);
                        break;
                    case 3:
                        DeleteArrayElement.DeleteArrayElementFunction(5, 8);
                        break;
                    case 4:
                        SumDiagonalElements.SumDiagonalElementsFunction(5);
                        break;

                }
            } while (userChoice != 0);
        }
    }
}
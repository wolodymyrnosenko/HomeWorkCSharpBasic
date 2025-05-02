using System.Collections.Generic;
using System.Text;

namespace Basic_13_1_ToDoList_rev2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            //List<string> toDoList = null;//For test
            List<string> toDoList = new List<string> {"one", "two", "three", "four", "five", "six", "seven"};//For test
            //List<string> toDoList = new List<string> { };

            Menu userChoice;
            do
            {
                Console.Clear();
                foreach (Menu menuItem in Enum.GetValues(typeof(Menu)))
                {
                    Console.WriteLine($"{(int)menuItem} - {menuItem.ToString().Replace('_', ' ')}");
                }
                Console.Write("Введіть номер за списком: ");
                try
                {
                    userChoice = (Menu)Convert.ToInt32(Console.ReadKey().KeyChar.ToString());
                }
                catch
                {
                    Console.Write($"{Environment.NewLine}Введіть число");
                    Console.ReadKey();
                    continue;
                }
                switch (userChoice)
                {
                    case Menu.Завершення_програми:
                        return;
                    case Menu.Додавання_справи:
                        AddToDoList(ref toDoList);
                        break;
                    case Menu.Виведення_всіх_справ:
                        if(IsExistToDoList(toDoList))
                        {
                            ShowToDoList(toDoList);
                        }
                        break;
                    case Menu.Відмітка_про_виконання:
                        if (IsExistToDoList(toDoList))
                        {
                            CheckToDoList(toDoList);
                        }
                        break;
                    case Menu.Видалення_справи:
                        if (IsExistToDoList(toDoList))
                        {
                            RemoveToDoList(toDoList);
                        }
                        break;
                    default:
                        Console.Write($"{Environment.NewLine}Введіть одну із вказаних цифр");
                        break;
                }
                Console.Write($"{Environment.NewLine}press any key to continue");
                Console.ReadKey();
            } while (true);
        }
        static void AddToDoList(ref List<string> lst)//Without ref created List (if null) do not exist in the other methods
        {
            if (lst == null)
            {
                lst = new List<string> { };
            }
            Console.Write($"{Environment.NewLine}Додайте справу: ");
            var eventUser = Console.ReadLine();
            if (eventUser != string.Empty && eventUser != null)
            {
                lst.Add(eventUser);
            }
            else
            {
                Console.WriteLine("не введена справа");
            }
        }
        static void RemoveToDoList(List<string> lst)
        {
            InputCorrectNumber(lst, out int indexEvent);
            lst.RemoveAt(indexEvent - 1);
        }
        static void ShowToDoList(List<string> lst)
        {
            Console.WriteLine($"{Environment.NewLine}Завантаження списку справ:");
            int i = 1;
            foreach (var ls in lst)
            {
                Console.WriteLine($"{i++}\t{ls}");
            }
        }
        public static void CheckToDoList(List<string> lst)
        {
            InputCorrectNumber(lst, out int indexEvent);
            lst[indexEvent - 1] = $"{new string('\b', (8 - indexEvent.ToString().Length))}-V-\t{lst[indexEvent - 1]}";
        }
        public static void InputCorrectNumber(List<string> lst, out int indexEvent)
        {
            while(true)
            {
                try
                {
                    Console.Write($"{Environment.NewLine}Введіть номер справи: ");
                    //indexEvent = Convert.ToInt32(Console.ReadKey().KeyChar.ToString());//Alow to use to-do list only less 10 items
                    indexEvent = Convert.ToInt32(Console.ReadLine().ToString());
                    if (indexEvent <= 0 || indexEvent > lst.Count)
                    {
                        Console.Write($"{Environment.NewLine}За таким номером справа відсутня");
                        continue;
                    }
                }
                catch
                {
                    Console.Write($"{Environment.NewLine}Введіть число");
                    continue;
                }
                return;
            }
        }
        public static bool IsExistToDoList(List<string> lst)
        {
            if (lst == null || lst.Count == 0)
            {
                Console.WriteLine($"{Environment.NewLine}Список справ порожній");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

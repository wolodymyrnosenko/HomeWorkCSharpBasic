using System;
using System.Text;

namespace Basic_13_1_ToDoList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            //List<string> toDoList = null;//For test
            //List<string> toDoList = new List<string> {"one", "two", "three", "four", "five", "six", "seven"};//For test
            List<string> toDoList = new List<string> { };

            Menu userChoice;
            do
            {
                Console.Clear();
                foreach (var menuItem in Enum.GetValues(typeof(Menu)))
                {
                    Console.WriteLine($"{(int)menuItem} - {menuItem}");
                }

                Console.Write("Введіть номер за списком: ");
                try
                {
                    userChoice = (Menu)Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Введіть цифру");
                    Console.ReadLine();
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
                        ShowToDoList(toDoList);
                        break;
                    case Menu.Відмітка_про_виконання:
                        CheckToDoList(toDoList);
                        break;
                    case Menu.Видалення_справи:
                        RemoveToDoList(toDoList);
                        break;
                }
                Console.ReadLine();
            } while (true);
        }
        static void AddToDoList(ref List<string> lst)//Without ref created List (if null) do not exist in the other methods
        {
            if (lst == null)
            {
                lst = new List<string> { };
            }
            Console.Write("Додайте справу: ");
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
            if (lst == null || lst.Count == 0)
            {
                Console.WriteLine("Список справ порожній");
                return;
            }
            Console.Write("Введіть номер справи для видалення: ");
            int indexEvent = 0;
            try
            {
                indexEvent = Convert.ToInt32(Console.ReadLine());
                if (indexEvent > 0 && indexEvent <= lst.Count)
                {
                    lst.RemoveAt(indexEvent - 1);
                }
                else
                {
                    Console.WriteLine("за таким номером справа відсутня");
                }
            }
            catch
            {
                Console.WriteLine("Введіть число!");
            }
        }
        static void ShowToDoList(List<string> lst)
        {
            if(lst == null || lst.Count == 0)
            {
                Console.WriteLine("Список справ порожній");
            }
            else
            {
                Console.WriteLine("Завантаження списку справ:");
                int i = 1;
                foreach (var ls in lst)
                {
                    Console.WriteLine($"{i++}\t{ls}");
                }
            }
        }

        public static void CheckToDoList(List<string> lst)
        {
            if (lst == null || lst.Count == 0)
            {
                Console.WriteLine("Список справ порожній");
                return;
            }
            Console.Write("Введіть номер виконаної справи: ");
            int indexEvent = 0;
            try
            {
                indexEvent = Convert.ToInt32(Console.ReadLine());
                if (indexEvent > 0 && indexEvent <= lst.Count)
                {
                    lst[indexEvent - 1] = $"{new string('\b', (8 - indexEvent.ToString().Length))}-V-\t{lst[indexEvent - 1]}";
                }
                else
                {
                    Console.WriteLine("за таким номером справа відсутня");
                }
            }
            catch
            {
                Console.WriteLine("Введіть число!");
            }
        }
    }
}
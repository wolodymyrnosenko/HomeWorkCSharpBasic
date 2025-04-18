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


            string[] menuItems = {"0 - Завершення програми",
                                "1 - Додавання справи",
                                "2 - Виведення всіх справ",
                                "3 - Відмітка про виконання",
                                "4 - Видалення справи"};
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
                        AddToDoList(ref toDoList);
                        break;
                    case 2:
                        ShowToDoList(toDoList);
                        break;
                    case 3:
                        CheckToDoList(toDoList);
                        break;
                    case 4:
                        RemoveToDoList(toDoList);
                        break;
                }
                Console.ReadLine();
            } while (userChoice != 0);
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
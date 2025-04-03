//За допомогою enum створити програму, що буде запитувати у користувача кількість днів,
//а потім рахувати який буде день через введену кількість, якщо рахувати від понеділка
//і виводити результат. Наприклад:
//Приклад 1: Вхідний параметр: 13 Очікуваний вивід: Sunday
//Приклад 2: Вхідний параметр: 3 Очікуваний вивід: Thursday
namespace Basic_08_1_Arrays
{
    internal class DayOfWeekEnum
    {
        enum WeekDays
        {
            Monday = 0,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        public static void DayOfWeekEnumFunction()
        {
            Console.Clear();
            Console.Write("Введіть кількість днів від понеділка: ");
            int userNumber = 0;
            try
            {
                userNumber = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("помилка");
            }
            if (userNumber < 1)
            {
                return;
            }
            else 
            {
                Console.WriteLine($"{(WeekDays)(userNumber%7)}");
            }
            Console.ReadLine();
        }
    }
}
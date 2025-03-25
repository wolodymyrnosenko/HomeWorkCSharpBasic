using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_06_1_Loops
{
    internal class PayForHour
    {
        public static void payForHour()
        {
            Console.Clear();
            Console.WriteLine("Калькулятор оплати праці за годину");
            double hoursInDay = 0;
            double hourSalary = 0;
            try
            {
                Console.WriteLine("Введіть кількість годин на день: ");
                hoursInDay = double.Parse(Console.ReadLine());
                Console.WriteLine("Введіть розмір годинної ставки: ");
                hourSalary = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("помилка");
            }

            if (hourSalary != 0 && hoursInDay != 0)
            {
                Console.Write($"Оплата за день складає: {Math.Round((hoursInDay * hourSalary), 2)}");
            }

            Console.ReadLine();
        }
    }
}

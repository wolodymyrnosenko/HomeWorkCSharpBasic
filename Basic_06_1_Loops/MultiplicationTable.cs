using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_06_1_Loops
{
    internal class MultiplicationTable
    {
        public static void multiplicationTable()
        {
            Console.Clear();
            Console.WriteLine("Генерація таблиці множення для конкретного числа");
            Console.Write("Введіть число: ");
            int number = 0;
            try
            {
                number = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("помилка");
                return;
            }
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{number} x {i} = {number * i}");
            }
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_06_1_Loops
{
    internal class CheckJustNumber
    {
        public static void checkJustNumber()
        {
            Console.Clear();
            Console.WriteLine("Перевірка на простоту");
            Console.Write("Введіть натуральне число: ");
            int justNumber = 0;
            int debtor = 0;
            try
            {
                justNumber = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("помилка");
            }
            if (justNumber < 1)
            {
                return;
            }
            else if (justNumber == 1)
            {
                Console.WriteLine("1 - не відноситься до простих чисел");
            }
            else
            {
                for (int i = 1; i <= justNumber; i++)
                {
                    if (justNumber % i == 0)
                    {
                        debtor++;
                    }
                    if (debtor > 2)
                    {
                        break;
                    }
                }
                if (debtor == 2)
                {
                    Console.WriteLine($"{justNumber} - просте число");
                }
                else
                {
                    Console.WriteLine($"{justNumber} - не відноситься до простих чисел");
                }
            }
            Console.ReadLine();
        }
    }
}

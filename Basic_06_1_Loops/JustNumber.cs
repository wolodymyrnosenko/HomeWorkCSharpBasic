using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_06_1_Loops
{
    internal class JustNumber
    {
        public static void justNumber()
        {
            Console.Clear();
            Console.WriteLine("Генерація простих чисел ");
            Console.Write("Введіть від одного і більше кінцеве натуральне число: ");
            int justNumber = 1;
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
                Console.WriteLine("Прості числа: ");
                for (int i = 1, debtor; i <= justNumber; i++)
                {
                    debtor = 0;
                    for (int j = 1; j <= i; j++)
                    {
                        if (i % j == 0)
                        {
                            debtor++;
                        }
                    }
                    if (debtor > 2)
                    {
                        continue;
                    }
                    Console.Write(i + " ");
                }
            }
            Console.ReadLine();
        }
    }
}

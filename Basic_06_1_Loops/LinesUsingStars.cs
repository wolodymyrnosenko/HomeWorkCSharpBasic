using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_06_1_Loops
{
    internal class LinesUsingStars
    {
        public static void linesUsingStars()
        {
            Console.Clear();
            Console.WriteLine("Побудова графіку зірочками: ");
            Console.Write("Введіть кількість рядків: ");
            int quantityStars = 0;
            try
            {
                quantityStars = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("помилка");
            }
            for (int i=0; i<=quantityStars; i++)
            {
                for(int j=0; j<i; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_06_1_Loops
{
    internal class AverageSalary
    {
        public static void averageSalary()
        {
            Console.Clear();
            Console.WriteLine("Обчислення середнього заробітку");
            Console.WriteLine("Введіть кількість працівників: ");
            int quantityWorkers = 0;
            double workerSalary = 0;
            double totalSalary = 0;
            try
            {
                quantityWorkers = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("введість число");
            }

            for (int i=0; i<quantityWorkers; i++)
            {
                Console.Write($"зарплата {i+1}-го працівника: ");
                try
                {
                    workerSalary = double.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("помилка");
                    return;
                }
                totalSalary += workerSalary;
            }
            if (quantityWorkers != 0)
            {
                Console.WriteLine($"Середній заробіток складає: {totalSalary / quantityWorkers}");
            }
            Console.ReadLine();
        }
    }
}

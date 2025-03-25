using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_06_1_Loops
{
    internal class FibonacciNumbers
    {
        public static void fibonacciNumbers()
        {
            Console.Clear();
            Console.WriteLine("Генерація Фібоначчівської послідовності");
            Console.Write("Введіть кількість чисел для генерації: ");
            int fibonacciNumber = 0;
            int quantityNumber = 1;
            try
            {
                quantityNumber = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("помилка");
                return;
            }
            if (quantityNumber < 1)
            {
                return;
            }
            else
            {
                Console.WriteLine("Числа Фібоначчі: ");
                int temp1 = 0;
                int temp2 = 0;
                for (int i = 0; i < quantityNumber; i++)
                {
                    Console.Write($"{fibonacciNumber} ");
                    if(i == 0)
                    {
                        fibonacciNumber = 1;
                        temp2 = 1;
                        continue;
                    }
                    temp1 = fibonacciNumber;
                    fibonacciNumber = temp2;
                    temp2 += temp1;
                }
            }
            Console.ReadLine();
        }
    }
}

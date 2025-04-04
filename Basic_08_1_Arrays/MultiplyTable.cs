//Створити та заповнити двовимірний масив розміру 9х9
//з результатами таблиці множення (у першому рядку мають бути
//записані добутки кожного з чисел від 1 до 9 на 1, у другому – на 2, ...,
//в останньому – на 9). Тобто в 1 строчці будуть значення від 1 до 9,
//а у другому 2,4,6,....,18 і т.д.
namespace Basic_08_1_Arrays
{
    internal class MultiplyTable
    {
        public static void MultiplyTableFunction()
        {
            Console.Clear();
            Console.WriteLine("Таблиця множення:");
            int size = 9;
            int[][] multTable = new int[size][];
            for (int i = 0; i < size; i++)
            {
                multTable[i] = new int[size];
            }
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    multTable[i][j] = (i + 1) * (j + 1);
                    Console.Write($"{multTable[i][j]}\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
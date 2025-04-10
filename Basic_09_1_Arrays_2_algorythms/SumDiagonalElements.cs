namespace Basic_09_1_Arrays_2_algorythms
{
    internal class SumDiagonalElements
    {
        public static void SumDiagonalElementsFunction(int size)
        {
            Console.Clear();
            if (size == 0)
            {
                Console.WriteLine("двовимірний масив відсутній");
                Console.ReadLine();
                return;
            }
            int[][] array = new int[size][];
            for (int i = 0; i < size; i++)
            {
                array[i] = new int[size];
            }
            Random rand = new Random();
            int sumLeftDiagonal = 0;
            int sumRightDiagonal = 0;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    array[i][j] = rand.Next(1, 10);
                    Console.Write($"{array[i][j]}\t");
                    if (i == j)
                    {
                        sumLeftDiagonal += array[i][j];
                    }
                    if (i == (size - 1 - j))
                    {
                        sumRightDiagonal += array[i][j];
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Сума елементів по діагоналі \\: {sumLeftDiagonal}");
            Console.WriteLine($"Сума елементів по діагоналі /: {sumRightDiagonal}");
            Console.ReadLine();
        }
    }
}
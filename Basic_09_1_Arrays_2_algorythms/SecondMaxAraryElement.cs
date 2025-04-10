namespace Basic_09_1_Arrays_2_algorythms
{
    internal class SecondMaxAraryElement
    {
        public static void SecondMaxArrayElementFunction(int rows, int columns)
        {
            Console.Clear();
            if (rows == 0 || columns == 0)
            {
                Console.WriteLine("двовимірний масив відсутній");
                Console.ReadLine();
                return;
            }
            int[][] array = new int[rows][];
            for (int i = 0; i < rows; i++)
            {
                array[i] = new int[columns];
            }
            Random rand = new Random();
            int[] maxNumber = { int.MinValue, int.MinValue };//To save max and second max elements
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i][j] = rand.Next(1, 101);
                    Console.Write($"{array[i][j]}\t");
                    if (array[i][j] > maxNumber[0])
                    {
                        maxNumber[1] = maxNumber[0];
                        maxNumber[0] = array[i][j];
                    }
                    else if (array[i][j] > maxNumber[1] && array[i][j] != maxNumber[0])
                    {
                        maxNumber[1] = array[i][j];
                    }
                }
                Console.WriteLine();
            }
            if (maxNumber[0] == maxNumber[1] || maxNumber[1] == int.MinValue)
            {
                Console.WriteLine("Масив заповнений однаковими числами");
                Console.ReadLine();
                return;
            }
            Console.WriteLine($"Другий найбільший елемент: {maxNumber[1]}");
            Console.ReadLine();
        }
    }
}
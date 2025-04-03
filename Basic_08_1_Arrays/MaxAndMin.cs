//Створити двовимірний масив 5х5. Заповнити його будь-якими числами.
//Визначити та вивести на екран: а) максимальний елемент масиву;
//б) мінімальний елемент масиву;
//в) координати мінімального елемента масиву.
//г) координати максимального елемента масиву.
namespace Basic_08_1_Arrays
{
    internal class MaxAndMin
    {
        public static void MaxAndMinFunction()
        {
            Console.Clear();
            Console.WriteLine("Максимум і мінімум у масиві 5x5:");
            int size = 5;
            int minRand = 1;
            int maxRand = 20;
            int[][] array = new int[size][];
            for (int i = 0; i < size; i++)
            {
                array[i] = new int[size];
            }
            Random rand = new Random();
            int max = 0;
            int min = 0;
            int[] maxCoordinates = new int[size * size * 2];
            int[] minCoordinates = new int[size * size * 2];
            int countMax = 0;
            int countMin = 0;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    array[i][j] = rand.Next(minRand,maxRand+1);
                    Console.Write($"{array[i][j]}\t");

                    if (i==0 && j==0)
                    {
                        max = array[i][j];
                        countMax = 1;
                        maxCoordinates[countMax * 2 - 2] = i;
                        maxCoordinates[countMax * 2 - 1] = j;
                        min = array[i][j];
                        countMin = 1;
                        minCoordinates[countMin * 2 - 2] = i;
                        minCoordinates[countMin * 2 - 1] = j;
                    }
                    //max = (max > array[i][j] ? max : array[i][j]);
                    //min = (min < array[i][j] ? min : array[i][j]);
                        
                    //Check is max and record coordinates
                    if (max < array[i][j])
                    {
                        max = array[i][j];
                        countMax = 1;
                        maxCoordinates[countMax * 2 - 2] = i;
                        maxCoordinates[countMax * 2 - 1] = j;
                    }
                    else if (max == array[i][j] && (i > 0 || j > 0))
                    {
                        countMax++;
                        maxCoordinates[countMax * 2 - 2] = i;
                        maxCoordinates[countMax * 2 - 1] = j;
                    }

                    //Check is min and record coordinates
                    if (min > array[i][j])
                    {
                        min = array[i][j];
                        countMin = 1;
                        minCoordinates[countMin * 2 - 2] = i;
                        minCoordinates[countMin * 2 - 1] = j;
                    }
                    else if (min == array[i][j] && (i > 0 || j > 0))
                    {
                        countMin++;
                        minCoordinates[countMin * 2 - 2] = i;
                        minCoordinates[countMin * 2 - 1] = j;
                    }
                }
                Console.WriteLine();
            }
            if (max == min)
            {
                Console.WriteLine("Масив заповнений однаковими числами");
            }
            else
            {
                Console.WriteLine($"а: max = {max}");
                Console.WriteLine($"б: min = {min}");
                Console.WriteLine($"в: coordinates of {countMin} min:");
                for (int i = 1; i <= countMin; i++)
                {
                    Console.WriteLine($"{minCoordinates[i * 2 - 2]}, {minCoordinates[i * 2 - 1]}");
                }
                Console.WriteLine($"г: coordinates of {countMax} max:");
                for (int i = 1; i <= countMax; i++)
                {
                    Console.WriteLine($"{maxCoordinates[i * 2 - 2]}, {maxCoordinates[i * 2 - 1]}");
                }

            }
            Console.ReadLine();
        }
    }
}
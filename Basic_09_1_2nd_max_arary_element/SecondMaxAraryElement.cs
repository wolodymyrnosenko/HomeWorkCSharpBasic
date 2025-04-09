
using System.Drawing;

namespace Basic_09_1_Arrays_2
{
    internal class SecondMaxAraryElement
    {
        public static void SecondMaxAraryElementFunction(int rows, int columns)
        {
            int[][] array = new int[rows][];
            for (int i = 0; i < rows; i++)
            {
                array[i] = new int[columns];
            }
            Random rand = new Random();
            int[][] maxValueCoordinates = new int[2][];
            maxValueCoordinates[0][] = new int[2];//To save max element
            maxValueCoordinates[1][] = new int[2];//To save second max element
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    array[i][j] = rand.Next(minRand, maxRand + 1);
                    Console.Write($"{array[i][j]}\t");

                    if (i == 0 && j == 0)
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




            if (array.Length == 0)
            {
                return 0;
            }
            int max = array[0];
            foreach (int ar in array)
            {
                if (max > ar)
                {
                    max = ar;
                }
            }
            return max;

        }
    }
}
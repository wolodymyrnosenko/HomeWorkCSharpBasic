
using static System.Net.Mime.MediaTypeNames;

namespace Basic_09_1_Arrays_2_algorythms
{
    internal class DeleteArrayElement
    {
        public static void DeleteArrayElementFunction(int rows, int columns)
        {
            Console.Clear();
            if (rows == 0 || columns == 0)
            {
                Console.WriteLine("двовимірний масив відсутній");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("Згенерований масив:");
            int[][] array = new int[rows][];
            Random rand = new Random();
            for (int i = 0; i < rows; i++)
            {
                array[i] = new int[columns];
                for (int j = 0; j < columns; j++)
                {
                    array[i][j] = rand.Next(1, 101);
                    Console.Write($"{array[i][j]}\t");
                }
                Console.WriteLine();
            }
            Console.Write("Введіть через кому індекс елемента для видалення: ");
            string[] deleteIndexString = Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries);
            if (deleteIndexString.Length != 2)
            {
                Console.WriteLine("помилкові дані");
                Console.ReadLine();
                return;
            }
            int[] deleteIndex = new int[2];
            try
            {
                deleteIndex[0] = Convert.ToInt32(deleteIndexString[0]);
                deleteIndex[1] = Convert.ToInt32(deleteIndexString[1]);
            }
            catch
            {
                Console.WriteLine("помилкові дані");
                Console.ReadLine();
                return;
            }
            if (deleteIndex[0] < 0 || deleteIndex[0] >= rows || deleteIndex[1] < 0 || deleteIndex[1] >= columns)
            {
                Console.WriteLine("помилкові дані");
                Console.ReadLine();
                return;
            }
            //Temp array for recording data
            int[] temp = new int[array[deleteIndex[0]].Length - 1];
            for(int i = 0, j = 0; i < array[deleteIndex[0]].Length; i++)
            {
                if(i == deleteIndex[1])
                {
                    continue;
                }
                temp[j] = array[deleteIndex[0]][i];
                j++;
            }
            //Update array
            array[deleteIndex[0]] = temp;
            //Output in console array
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write($"{array[i][j]}\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
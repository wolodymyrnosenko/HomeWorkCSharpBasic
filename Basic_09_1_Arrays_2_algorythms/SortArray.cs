
namespace Basic_09_1_Arrays_2_algorythms
{
    internal class SortArray
    {
        public static void SortArrayFunction(int rows, int columns)
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
                //foreach(var ar in array[i])
                //{
                //    ar = rand.Next(1, 101);//чому не можна ініціалізувати? або як треба у foreach? 
                //    Console.Write($"{ar}\t");
                //}
                for (int j = 0; j < columns; j++)
                {
                    array[i][j] = rand.Next(1, 101);
                    Console.Write($"{array[i][j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Відсортовані підмасиви:");
            for (int i = 0; i < array.Length; i++)
            {
                //if-else to test different sorting
                if(i % 2 != 0)
                {
                    Array.Sort(array[i]);
                }
                else
                {
                    array[i] = SortBuble(array[i]);
                }
                ShowConsole(array[i]);
            }
            Console.WriteLine("Відсортований повністю масив:");
            array = SortBuble(array);
            ShowConsole(array);
            Console.ReadLine();
        }
        public static int[] SortBuble(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    { 
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            return arr;
        }
        public static int[][] SortBuble(int[][] arr)
        {
            //Convert [][] to []
            int[] temp = new int[arr.Length * arr[0].Length];
            int indexTemp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    temp[indexTemp] = arr[i][j];
                    indexTemp++;
                }
            }
            temp = SortBuble(temp);
            indexTemp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = temp[indexTemp];
                    indexTemp++;
                }
            }
            return arr;
        }

        public static void ShowConsole(int[] arr)
        {
            foreach (var ar in arr)
            { 
                Console.Write($"{ar}\t");
            }
            Console.WriteLine();
        }
        public static void ShowConsole(int[][] arr)
        {
            foreach (var ar in arr)
            {
                ShowConsole(ar);
            }
        }
    }
}
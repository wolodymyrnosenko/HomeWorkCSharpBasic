//Створіть метод, що буде повертати транспоновану матрицю.
//Транспонована матриця - така матриця, де строки стають стовпцями.
namespace Basic_09_bonus_04_transpose_matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        // Метод для транспонування
        public static int[,] Transpose(int[,] matrix)
        {
            // Писати код тут
            int rows = matrix.GetLength(1);
            int columns = matrix.GetLength(0);
            int[,] transpArray = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    transpArray[i,j] = matrix[j,i];
                }
            }
            return transpArray;
        }
    }
}

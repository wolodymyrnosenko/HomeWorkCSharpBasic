//Створіть метод, що буде перевіряти чи однакові між собою всі елементи
//двох матриць чи ні. Гарантується, що матриці завжди однакового розміру.
namespace Basic_09_bonus_05_compare_matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        // Метод для перевірки рівності
        public static bool CompareMatrix(int[][] matrix1, int[][] matrix2)
        {
            // Писати код тут
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    if (matrix1[i][j] != matrix2[i][j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}

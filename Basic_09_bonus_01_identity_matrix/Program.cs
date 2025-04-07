//Створіть метод, що буде перевіряти, чи є надана матриця одиничною.
//Умови натупні - на головній діагоналі всі елементи мають дорінювати 1,
//а всі інші - 0. Якщо так, то повернути true, якщо ні, то повернути false.
namespace Basic_09_bonus_01_identity_matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        // Метод для перевірки масиву
        public static bool MatrixIdentity(int[][] array)
        {
            // Писати код тут
            for(int i = 0; i < array.Length; i++)
            {
                for(int j = 0; j < array.Length; j++)
                {
                    if (i == j && array[i][j] != 1)
                    {
                        return false;
                    }else if (i != j && array[i][j] != 0)
                    {
                        return false;
                    }
                }
            }
        return true;
        }
    }
}

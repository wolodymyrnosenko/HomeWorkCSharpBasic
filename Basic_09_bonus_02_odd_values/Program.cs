//Створіть метод, що буде повертати тільки непарні елементи масиву.
//Якщо таких елементів в масиві нема, то повернути null.
namespace Basic_09_bonus_02_odd_values
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        // Метод для перевірки масиву
        public static int[]? OnlyOddValues(int[] array)
        {
            // Писати код тут
            int index = 0;
            int[] arrayReturn = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                if ((array[i] % 2) != 0)
                {
                    arrayReturn[index++] = array[i];
                }
            }
            int[] temp = new int[index];
            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = arrayReturn[i];
            }
            arrayReturn = temp;
            return arrayReturn;
        }
    }
}

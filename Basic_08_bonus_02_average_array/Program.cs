//Створіть метод для знаходження середнього арифметичного елементів масиву.
//Якщо масив порожній, повернути значення 0
namespace Basic_08_bonus_02_average_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        // Метод для знаходження середнього арифметичного елементів масиву
        public static double ArrayAverage(int[] array)
        {
            // Писати код тут
            int sum = 0;
            foreach(int ar in array)
            {
                sum += ar;
            }
            return sum / array.Length;
        }
    }
}

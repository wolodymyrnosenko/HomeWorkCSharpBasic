//Напишіть програму для знаходження найбільшого значення в масиві.
//Якщо масив порожній, повернути значення 0.
namespace Basic_08_bonus_05_max_value
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        // Метод для пошуку значення
        public static int MaxValue(int[] array)
        {
            // Писати код тут
            if (array.Length == 0)
            {
                return 0;
            }
            int max = array[0];
            foreach(int ar in array)
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

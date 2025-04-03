//Створіть метод, що буде перевіряти, чи дійсно всі елементи масиву
//розташовані за зростанням. Якщо так, то повернути 1, якщо ні,
//то повернути -1, якщо масив порожній або всі елементи масиву рівні - 0.


namespace Basic_08_bonus_01_growing_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

        }


        // Метод для перевірки масиву
        public static int ArrayAscensionCheck(int[] array)
        {
            // Писати код тут
            int _return = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[i-1])
                {
                    _return = 1;
                }
                else if (array[i] < array[i - 1])
                {
                    return -1;
                }
            }
            return _return;
        }
    }
}

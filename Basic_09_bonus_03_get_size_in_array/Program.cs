//Створіть метод, що буде повертати розмір найбільшого висхідного підмасиву
//(такий, де кожен наступний елемент більше за попередній) із заданого масиву.
//Якщо всі елементи розташовані за спаданням, то повернути 1. Наприклад:

//{ 1,3,2,4,6,8} → 4({ 2,4,6,8})
//{ 9,8,3,1} → 1
//{ 1,3,2,2} → 2({ 1,3}) 
//{ 1,9,1,5,9} → 3({ 1,5,9})

namespace Basic_09_bonus_03_get_size_in_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] test = { 1, 3, 2, 4, 6, 8 };
            //int[] test = { 9, 8, 3, 1 };
            //int[] test = { 1, 3, 2, 2 };
            int[] test = { 1, 9, 1, 5, 9 };

            int testOutput = ArrayAscensionSizeCheck(test);
            Console.WriteLine($"quantity = {testOutput}");
        }
        // Метод для перевірки масиву
        public static int ArrayAscensionSizeCheck(int[] array)
        {
            // Писати код тут
            int size = 1;
            int tempSize = 1;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[i-1])
                {
                    size++;
                } else if(array[i] < array[i - 1])
                {
                    tempSize = size;
                    size = 1;
                }
            }
            return (size > tempSize) ? size : tempSize;
        }
    }
}

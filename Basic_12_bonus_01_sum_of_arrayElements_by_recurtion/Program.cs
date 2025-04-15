//Створіть метод, що буде рахувати суму всіх елементів масиву.
//Спробувати виконати це завдання за допомогою рекурсії. Наприклад:
//Вхідний масив: 1,2,3,4,5 Вихідне значення: 15
//Вхідний масив: 1,1 Вихідне значення: 2
namespace Basic_12_bonus_01_sum_of_arrayElements_by_recurtion
{
    internal class Program
    {
        public static void Main()
        {
            //Console.WriteLine(SumArray(1, 2, 3, 4, 5));
            //Console.WriteLine(SumArray(1, 1));
            int[] test = { 1, 2, 3, 4, 5 };
            Console.WriteLine(SumArray(test));
            int[] test2 = { 1, 1 };
            Console.WriteLine(SumArray(test2));
        }
        public static int SumArray(int[] numbers)
        {
            // Писати код тут
            if (numbers.Length == 1)
            {
                return numbers[0];
            }
            int[] temp = new int[numbers.Length - 1];
            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = numbers[i];
            }
            return numbers[numbers.Length - 1] + SumArray(temp);
        }
        //public static int SumArray(params int[] numbers)
        //{
        //    // Писати код тут
        //    if (numbers.Length == 1)
        //    {
        //        return numbers[0];
        //    }
        //    int[] temp = new int[numbers.Length - 1];
        //    for (int i = 0; i < temp.Length; i++)
        //    {
        //        temp[i] = numbers[i];
        //    }
        //    return numbers[numbers.Length - 1] + SumArray(temp);
        //}
    }
}

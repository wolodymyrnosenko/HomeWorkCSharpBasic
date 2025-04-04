
namespace Basic_08_1_Arrays
{
    internal class SumOfElements
    {
        public static void SumOfElementsFunction()
        {
            Console.Clear();
            Console.WriteLine("Перевірка суми елементів масиву на невід'ємність");
            var rand = new Random();
            int[] array = new int[10];
            int sumOfElements = 0;
            int sumOfEvenIndexes = 0;
            Console.Write("All array:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-10, 11);
                Console.Write($" {array[i]}");
                sumOfElements += array[i];
            }
            Console.Write($"{Environment.NewLine}Only even index:");
            for (int i = 0; i < array.Length; i += 2)
            {
                Console.Write($" {array[i]}");
                sumOfEvenIndexes += array[i];
            }
            Console.Write($"{Environment.NewLine}Сума всіх елементів дорівнює {sumOfElements} і є невід'ємним - {sumOfElements > 0}");
            Console.Write($"{Environment.NewLine}Сума елементів парних індексів дорівнює {sumOfEvenIndexes} і є невід'ємним - {sumOfEvenIndexes > 0}");
            Console.ReadLine();
        }
    }
}
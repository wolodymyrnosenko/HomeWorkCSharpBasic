//Створити масив із 10 елементів типу int.
//Присвоїти їм випадкові значення від -10 до 10,
//використовуючи клас Random
//(https://learn.microsoft.com/en-us/dotnet/api/system.random?view=net-8.0)
//Вивести на екран елементи масиву з парним індексом.
//(не парні значення, а саме парні індекси!!)
namespace Basic_08_1_Arrays
{
    internal class NumersOnEvenIndex
    {
        public static void NumbersOnEvenIndexFunction()
        {
            Console.Clear();
            Console.WriteLine("Рандомная (-10:10) генерація масиву із 10 елементів");
            var rand = new Random();
            int[] array = new int[10];
            Console.Write("All array:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-10, 11);
                Console.Write($" {array[i]}");
            }
            Console.Write($"{Environment.NewLine}Only even index:");
            for (int i = 0; i < array.Length; i += 2)
            {
                Console.Write($" {array[i]}");
            }
            Console.ReadLine();
        }
    }
}
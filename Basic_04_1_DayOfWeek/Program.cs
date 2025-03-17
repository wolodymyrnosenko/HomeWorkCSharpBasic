using System.Text;

namespace Basic_04_1_DayOfWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ukrainian in Console
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            
            //Input number by user
            Console.Write("Введіть число від 1 до 7 для визначення дня тижня: ");
            int dayOfWeek = Convert.ToInt32(Console.ReadLine());
            
            string nameDayOfWeek;//Variable for output

            //Using "if-else" to initialize nameDayOfWeek
            if (dayOfWeek == 1)
            {
                nameDayOfWeek = "Понеділок";
            }
            else if (dayOfWeek == 2)
            {
                nameDayOfWeek = "Вівторок";
            }
            else if (dayOfWeek == 3)
            {
                nameDayOfWeek = "Середа";
            }
            else if (dayOfWeek == 4)
            {
                nameDayOfWeek = "Четвер";
            }
            else if (dayOfWeek == 5)
            {
                nameDayOfWeek = "П'ятниця";
            }
            else if (dayOfWeek == 6)
            {
                nameDayOfWeek = "Субота";
            }
            else if (dayOfWeek == 7)
            {
                nameDayOfWeek = "Неділя";
            }
            else
            {
                nameDayOfWeek = "Введені дані не відповідають числу від 1 до 7";
            }

            //Result output string
            string forOutput = (dayOfWeek >= 1 && dayOfWeek <= 7) ?
                                $"Введеному числу відповідає день тижня - {nameDayOfWeek}" :
                                nameDayOfWeek;

            //Output to Console
            Console.WriteLine(forOutput);
        }
    }
}

using System.Text;

namespace Basic_10_1_compare_first_letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.Write("Введіть ім'я та прізвище: ");
            string complexName = Console.ReadLine();
            if(CompareFirstLetters(complexName))
            {
                Console.WriteLine("Прізвище починається на ту ж літеру, що і ім’я");
            }else
            {
                Console.WriteLine("Прізвище не починається на ту ж літеру, що і ім’я");
            }
        }
        public static bool CompareFirstLetters(string txt)
        {
            string[] nameAndSurname = txt.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            if(nameAndSurname.Length == 0)
            {
                Console.WriteLine("дані відсутні");
                return false;
            }else if (nameAndSurname.Length > 2)
            {
                Console.WriteLine("зайві дані для порівняння");
                return false;
            }
            else
            {
                string name = nameAndSurname[0];
                string surname = nameAndSurname[1];
                if (char.ToUpper(name[0]) == char.ToUpper(surname[0]))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}

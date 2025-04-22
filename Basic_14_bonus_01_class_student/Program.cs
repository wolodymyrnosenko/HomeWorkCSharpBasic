//Створити клас Student з полями Name та Age.
//Поля мають буті відкриті для отримання та редагування.
//В класі Student повинен бути конструктор, що присвоює стандартне ім’я “Undefined”.
namespace Basic_14_bonus_01_class_student
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    public class Student
    {
        public string name;
        public int age;
        public Student()
        {
            name = "Undefined";
        }
    }
}

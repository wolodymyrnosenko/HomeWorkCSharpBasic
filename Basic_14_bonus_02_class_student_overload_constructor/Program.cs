//Створити клас Student з полями Name та Age.
//Поля мають буті відкриті для отримання та редагування.
//Створити перевантажені конструктори, що задають значення цих полів.
//Перший конструктор приймає name та age
//Другий конструктор приймає тільки name
//Третій конструктор приймає тільки age.
//Ім’я має бути встановлено “Undefined”.
namespace Basic_14_bonus_02_class_student_overload_constructor
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
        public string Name = "Undefined";
        public int Age;
        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public Student(string name)
        {
            Name = name;
        }
        public Student(int age)
        {
            Age = age;
        }
    }
}

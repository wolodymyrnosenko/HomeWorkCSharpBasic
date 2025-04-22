//Створити клас Customer з полями Login та Email. Виконати наступні умови:
//Поле Login має бути обов’язковим під час ініціалізації об’єкту та закритим для подальшого редагування.
//Поля Login та Email мають бути відкриті для читання.
//Поле Email має можливість для встановлення значення, але значення обов’язково повинно містити символ @.
//Якщо умова не виконується, то має повертатись Exception.
using System.ComponentModel.DataAnnotations;

namespace Basic_14_bonus_03_class_customer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Customer address = new Customer("user");
            //address.Email = Console.ReadLine();
            address.Email = "gmail.com@";
            Console.WriteLine(address.Login);

        }
    }
    public class Customer
    {
        private string login;
        private string email;
        public string Login
        {
            get
            {
                return login;
            }
        }
        public string Email 
        {
            get
            {
                return email;
            }
            set
            {
                if (!value.Contains('@'))
                {
                    //Console.WriteLine("error");
                    throw new Exception();
                }
            } 
        }

        public Customer(string login)
        {
            this.login = login;
        }
    }
}

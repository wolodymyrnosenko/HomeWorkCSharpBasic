using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_14_1_AccountClass
{
    class Account
    {
        public string Name { get; }
        private double balance;
        public double Balance
        {
            get
            {
                return balance;
            }
            set
            {
                if(value >= 0)
                {
                    balance = value;
                }
                else
                {
                    Console.WriteLine("Стан рахунку не може бути менше за 0");
                }
            }
        }
        public Account(string name)
        {
            Name = name;
            balance = 0.00;
        }
        public Account(string name, double balance)//public Account(string name, double balance = 0.00)//Такий варіант використовується? (щоб обійтись без конструктора з одним параметром)
        {
            Name = name;
            Balance = balance;
        }
        public void Deposit(double sum)
        {
            Balance += sum;
        }
        public void Withdrawal(double sum)
        {
            Balance -= sum;
        }
    }
}
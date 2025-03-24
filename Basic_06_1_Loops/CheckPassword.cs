using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_06_1_Loops
{
    internal class CheckPassword
    {
        public static void checkPassword()
        {
            Console.Clear();
            Console.Write("Перевірка паролю");
            bool length = false;
            bool digit = false;
            bool charPassword = false;
            bool specialSymbol = false;
            string password;
            do
            {
                Console.WriteLine();
                Console.Write("Встановить пароль: ");
                length = false;
                digit = false;
                charPassword = false;
                specialSymbol = false;
                password = Console.ReadLine();
                if (password.Length < 8)
                {
                    Console.WriteLine("Довжина паролю має бути більше 8");
                }
                else
                {
                    length = true;
                    foreach (char ch in password)
                    {
                        if ((int)ch >= 33 && (int)ch < 48)
                        {
                            specialSymbol = true;
                        }
                        if ((int)ch >= 48 && ch <= 57)
                        {
                            digit = true;
                        }
                        if((ch >= 65 && ch <= 90) || (ch>=97 && ch <= 122))
                        {
                            charPassword = true;
                        }
                        if (specialSymbol == true && digit == true && charPassword == true)
                        {
                            break;
                        }
                    }
                    if (specialSymbol == false || digit == false || charPassword == false)
                    {
                        Console.Write("Пароль має містити букви, не менше однієї цифри та символ: ");
                        for (int i = 33; i < 48; i++)
                        {
                            Console.Write($"{(char)i} ");
                        }
                    }
                }
            } while (length == false || specialSymbol == false || digit == false || charPassword == false);
            Console.WriteLine("Пароль відповідає умовам");
            Console.ReadLine();
        }
    }
}

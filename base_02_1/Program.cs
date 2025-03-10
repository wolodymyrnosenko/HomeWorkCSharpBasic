using System.Text;

namespace Basic_02_1
{
    internal class Program
    {
        static byte numberOfOrder = 1;
        static void Main(string[] args)
        {
            //write and read Ukrainian in Console
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
                        
            //three calls according to task
            ConsoleOrder();
            ConsoleOrder();
            ConsoleOrder();
        }
        static void ConsoleOrder()
        {            
            Console.Write($"Введіть ім'я клієнта {numberOfOrder} замовлення: ");
            var clientName = Console.ReadLine();
            Console.Write("Введіть назву продукта: ");
            var productName = Console.ReadLine();
            Console.Write($"Введіть ціну {productName} (розділовий знак - кома): ");
            var productPrice = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введіть адресу: ");
            var addressOrder = Console.ReadLine();

            //total output of order
            Console.WriteLine();
            Console.WriteLine($"Order No {numberOfOrder}");
            Console.WriteLine($"Client: {clientName}.");
            Console.WriteLine("Product: {0}, price {1:0.00} EUR.", productName, Math.Round(productPrice, 2));
            Console.WriteLine($"Address: {addressOrder}.");
            Console.WriteLine();

            numberOfOrder++;
        }
    }
}

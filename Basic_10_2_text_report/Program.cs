using System.Text;

namespace Basic_10_2_text_report
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Створення текстового звіту");
            StringBuilder textReport = new StringBuilder();
            Console.Write("Введіть назву заходу на сьогодні: ");
            textReport.AppendLine(Console.ReadLine());
            textReport.AppendLine($"Дата: {DateTime.Now.ToString("dd.MM.yyyy")}");
            textReport.AppendLine($"Події:");
            StringBuilder events = new StringBuilder();
            char continueEvent;
            int countEvent = 1;
            do
            {
                Console.Write($"{Environment.NewLine}Введіть подію {countEvent}: ");
                events.AppendLine($"{countEvent++}. " + Console.ReadLine());
                Console.Write("Continue (Yes - y)?: ");
                continueEvent = Console.ReadKey().KeyChar;
            } while (continueEvent == 'Y' || continueEvent == 'y');
            textReport.Append(events);
            Console.Clear();
            Console.WriteLine(textReport.ToString());
            Console.ReadLine();
        }
    }
}

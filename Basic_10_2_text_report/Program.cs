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
            //textReport.AppendLine(Console.ReadLine());
            string titleReport = Console.ReadLine();
            textReport.AppendLine(titleReport);
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
            } while (continueEvent == 'y' || continueEvent == 'у');//lat and ukr versions of 'y'
            textReport.Append(events);
            Console.Clear();
            Console.WriteLine(textReport.ToString());

            //Version 2.0 with record index and length substring to stilyze the output
            Console.WriteLine("Другий варіант виводу звіту:");
            StringBuilder textReport2 = new StringBuilder();
            int titleStart = textReport2.Length;
            titleReport = CenterText(titleReport.ToUpper(), Console.WindowWidth);
            textReport2.AppendLine(titleReport);
            int titleLength = textReport2.Length - titleStart;

            int dateStart = textReport2.Length;
            string date = $"Дата: {DateTime.Now.ToString("dd.MM.yyyy")}";
            textReport2.AppendLine(date);
            int dateLength = textReport2.Length - dateStart;

            int eventsTitleStart = textReport2.Length;
            string eventsTitle = CenterText("Події:", Console.WindowWidth);
            textReport2.AppendLine(eventsTitle);
            int eventsTitleLength = textReport2.Length - eventsTitleStart;

            int eventsStart = textReport2.Length;
            textReport2.Append(events);
            int eventsLength = textReport2.Length - eventsStart;

            //Output
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.CursorSize = 20;//Не є розміром шрифта тексту
            Console.WriteLine(textReport2.ToString(titleStart, titleLength).TrimEnd());
            Console.WriteLine(textReport2.ToString(dateStart, dateLength).TrimEnd());
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(textReport2.ToString(eventsTitleStart, eventsTitleLength).TrimEnd());
            Console.WriteLine(textReport2.ToString(eventsStart, eventsLength).TrimEnd());
            Console.ReadLine();
        }
        public static string CenterText(string txt, int width)
        {
            if(txt.Length >= width)
            {
                return txt;
            }
            int leftPadding = (width - txt.Length) / 4;//For center /2
            return new string(' ', leftPadding) + txt;
        }
    }
}

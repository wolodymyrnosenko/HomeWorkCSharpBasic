//Ваша програма повинна зчитати дані з CSV-файлу (розділені комами) та вивести їх на екран.
//Припустимо, що перший рядок файлу містить назви стовпців.
//Ваша програма повинна вивести ці назви та вміст кожного рядка.
//Використайте StreamReader для зчитування файлу та роздільник, для розбиття рядків на поля.
//Приклад використання(для файлу data.csv)
//Назви стовпців: ID, Ім'я, Прізвище, Вік
//1, Олександр, Петров, 25
//2, Ірина, Сидорова, 30
//3, Максим, Іванов, 22
//...
//Підказка: Використовуйте Split(',') для розділення рядків на поля та File.Exists() для
//перевірки наявності файлу перед зчитуванням.

using System;
using System.IO;
using System.Text;

namespace Basic_16_bonus_01_FileCSV
{
    //internal class Program
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //string filePath = "path/to/your/csv/file.csv"; // Замініть на шлях до вашого CSV-файлу
            //string filePath = @"D:/data.csv";
            string filePath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\", "data.csv")); //Path in the project directory

            try
            {
                var csvReader = new CsvReader(filePath);
                csvReader.PrintColumnNames();
                csvReader.PrintDataRows();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Файл не знайдено. Перевірте правильність шляху до файлу.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
        }
    }

    public class CsvReader
    {
        private readonly string _filePath;

        public CsvReader(string filePath)
        {
            _filePath = filePath;
        }

        public void PrintColumnNames()
        {
            using (var reader = new StreamReader(_filePath))
            {
                string headerLine = reader.ReadLine();
                string[] columnNames = headerLine.Split(',');

                Console.WriteLine("Назви стовпців:");
                foreach (var columnName in columnNames)
                {
                    Console.WriteLine(columnName);
                }
            }
        }

        public void PrintDataRows()
        {
            using (var reader = new StreamReader(_filePath))
            {
                // Пропускаємо перший рядок (назви стовпців)
                reader.ReadLine();

                Console.WriteLine("\nВміст рядків:");
                while (!reader.EndOfStream)
                {
                    string dataLine = reader.ReadLine();
                    string[] fields = dataLine.Split(',');
                    int padRight = 3;
                    foreach (var field in fields)
                    {
                        //Console.Write(field + "\t");
                        Console.Write(field.PadRight(padRight));
                        padRight = 15;
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}

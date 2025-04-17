
namespace Basic_11_1_Gallows
{
    public static class GuessWord
    {
        public static string RandomWord()
        {
            List<string> words = new List<string>
            {
                "FirstWord",
                "ШИБЕНИЦЯ"
            };
            string strLorem = "Lorem Ipsum - це текст-\"риба\", що використовується в друкарстві та дизайні. Lorem Ipsum є, фактично, стандартною \"рибою\" аж з XVI сторіччя, коли невідомий друкар взяв шрифтову гранку та склав на ній підбірку зразків шрифтів. \"Риба\" не тільки успішно пережила п'ять століть, але й прижилася в електронному верстуванні, залишаючись по суті незмінною. Вона популяризувалась в 60-их роках минулого сторіччя завдяки виданню зразків шрифтів Letraset, які містили уривки з Lorem Ipsum, і вдруге - нещодавно завдяки програмам комп'ютерного верстування на кшталт Aldus Pagemaker, які використовували різні версії Lorem Ipsum.";
            char[] separators = new char[]{ ' ', ',', '.', ';', ':', '-', '\"', '!', '?' };
            string[] wordsFromLorem = strLorem.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < wordsFromLorem.Length; i++)
            {
                if (wordsFromLorem[i].Length > 3)
                {
                    words.Add(wordsFromLorem[i]);
                }
            }
            return words[new Random().Next(words.Count)]; 
        }
    }
}
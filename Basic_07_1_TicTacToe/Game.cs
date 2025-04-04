
namespace Basic_07_1_TicTacToe
{
    internal class Game
    {
        char[] cells = new char[9];
        public void Start()
        {
            Show(cells);
        }
        void Show(char[] ar)
        {

            for (int i = 0; i < ar.Length; i++)
            {
                ar[i] = (char)(i + 49);
                Console.Write($" {ar[i]} ");
                if((i + 1) == 9)
                {
                    break;
                }
                if ((i+1)%3==0)
                {
                    Console.Write($"{Environment.NewLine}-----------{Environment.NewLine}");
                    continue;
                }
                Console.Write("|");
            }
            Console.WriteLine($"{Environment.NewLine}{Environment.NewLine}хід ігрока: ");
        }
    }
}
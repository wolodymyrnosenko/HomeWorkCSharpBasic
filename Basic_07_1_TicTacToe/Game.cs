
namespace Basic_07_1_TicTacToe
{
    internal class Game
    {
        char[] cells = new char[9];
        bool playerXtrueOfalse = true;
        //playerXtrueOfalse = !playerXtrueOfalse;
        char move;

        public void Start()
        {
            Show(cells);
            move = Convert.ToChar(Console.ReadKey());
            Console.WriteLine();
        }
        void Show(char[] ar)
        {
            Console.Clear();
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
            Console.Write($"{Environment.NewLine}{Environment.NewLine}хід ігрока");
            if(playerXtrueOfalse)
            {
                Console.WriteLine(" X: ");
            }else
            {
                Console.WriteLine(" O: ");
            }
        }
    }
}
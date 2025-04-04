
namespace Basic_07_1_TicTacToe
{
    enum player
    {
        O=79,
        X=88
    }
    internal class Game
    {
        char[] cells = new char[9];
        bool playerXtrueOfalse = true;
        //playerXtrueOfalse = !playerXtrueOfalse;
        int move=0;//X~88, O~79

        public void Start()
        {
            for (int i = 0; i < cells.Length; i++)
            {
                cells[i] = (char)(i + 49);
            }
            Show(cells);


            //move = Convert.ToChar(Console.Read());
            //if(move>=49 && move<=57)
            //{
            //    Console.WriteLine(cells[move-49]);
            //    cells[move - 49] = (char)player.X;
            //}

            //move = int.Parse(Console.ReadKey());
            //if(move>=1 && move<=9)
            //{
            //    Console.WriteLine(move);
            //}


            Show(cells);

        }
        void Show(char[] ar)
        {
            Console.Clear();
            for (int i = 0; i < ar.Length; i++)
            {
                //ar[i] = (char)(i + 49);
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
                Console.Write(" X: ");
            }else
            {
                Console.Write(" O: ");
            }
        }
    }
}

namespace Basic_07_1_TicTacToe
{
    internal class Game
    {
        char[] cells = new char[9];
        char move;
        Player changePlayer;
        int countOfMoves;

        public void Start()
        {
            changePlayer = Player.X;
            countOfMoves = 0;
            //Initialize field (cells[]) from 1 to 9
            for (int i = 0; i < cells.Length; i++)
            {
                cells[i] = (char)(i + 49);
            }
            //Start game
            do
            {
                Show();
                Move();
            }while(!IsGameOver());
        }
        bool IsGameOver()
        {
            if ((cells[0] == cells[1] && cells[1] == cells[2]) ||
                (cells[3] == cells[4] && cells[4] == cells[5]) ||
                (cells[6] == cells[7] && cells[7] == cells[8]) ||
                (cells[0] == cells[4] && cells[4] == cells[8]) ||
                (cells[2] == cells[4] && cells[4] == cells[6]) ||
                (cells[0] == cells[3] && cells[3] == cells[6]) ||
                (cells[1] == cells[4] && cells[4] == cells[7]) ||
                (cells[2] == cells[5] && cells[5] == cells[8]))
            {
                Show();
                Console.WriteLine($"{Environment.NewLine}Переміг гравець {changePlayer}");
                return true;
            }else if(countOfMoves == 9)
            {
                Show();
                Console.WriteLine($"{Environment.NewLine}Ничія");
                return true;
            }
            else
            {
                changePlayer = (changePlayer == Player.X) ? Player.O : Player.X;
                return false;
            }
        }
        bool IsFilledCell(int index)
        {
            if (cells[index] >= 49 && cells[index] <= 57)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        void Move()
        {
            Console.Write($"{Environment.NewLine}{Environment.NewLine}Хід гравця {changePlayer}: ");
            do
            {
                move = Console.ReadKey().KeyChar;
                if (move >= 49 && move <= 57 && !IsFilledCell(move - 49))
                {
                    cells[move - 49] = (char)changePlayer;
                    countOfMoves++;
                    break;
                }else 
                {
                    Console.WriteLine($"{Environment.NewLine}Введіть цифру від 1 до 9 незайнятої клітинки");
                }
            } while (move <= 49 || move >= 57 || (move >= 49 && move <= 57 && IsFilledCell(move - 49)));
        }
        void Show()
        {
            Console.Clear();
            for (int i = 0; i < cells.Length; i++)
            {
                Console.Write($" {cells[i]} ");
                if((i + 1) == 9)
                {
                    break;
                }
                if ((i + 1) % 3 == 0)
                {
                    Console.Write($"{Environment.NewLine}-----------{Environment.NewLine}");
                    continue;
                }
                Console.Write("|");
            }
        }
    }
}
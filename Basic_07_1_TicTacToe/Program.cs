using System.Text;

namespace Basic_07_1_TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Game game = new Game();
            char continueGame;
            do
            {
                game.Start();
                Console.Write("Continue (Yes - y)?: ");
                continueGame = Console.ReadKey().KeyChar;
            } while (continueGame == 'Y' || continueGame == 'y');
        }
    }
}
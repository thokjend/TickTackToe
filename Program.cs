namespace TickTackToe
{
    internal class Program
    {
        private static List<char> board = new() { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        private static int player = 1;

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Player1: X and Player2: O");
                Console.WriteLine();
                
                Board();

                player = (player == 1) ? 2 : 1;
                Console.WriteLine($"Current Turn: Player {player}");
                Console.Write("Select number to place: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (board[choice] != 'X' && board[choice] != 'O')
                {
                    if (player == 1)
                    {
                        board[choice] = 'O';
                    }
                    else
                    {
                        board[choice] = 'X';
                    }
                }
                else
                {
                    Console.WriteLine("Sorry, the row {0} is already marked with {1}", choice, board[choice]);
                }
            }
        }

        public static void Board()
        {
            Console.WriteLine(" {0} | {1} | {2} ", board[0], board[1], board[2]);
            Console.WriteLine("---+---+---");
            Console.WriteLine(" {0} | {1} | {2} ", board[3], board[4], board[5]);
            Console.WriteLine("---+---+---");
            Console.WriteLine(" {0} | {1} | {2} ", board[6], board[7], board[8]);
        }
    }
}
namespace TickTackToe
{
    internal class Program
    {
        private static List<char> board = new() {'1', '2', '3', '4', '5', '6', '7', '8', '9' };
        private static int player = 1;
        private static int flag = -1;

        static void Main(string[] args)
        {
            while (flag == -1)
            {
                Console.Clear();
                Console.WriteLine("Player1: X and Player2: O");
                Console.WriteLine();
                
                Board();

                Console.WriteLine($"Current Turn: Player {player}");
                Console.Write("Select number to place: ");

                try
                {
                    int choice = Convert.ToInt32(Console.ReadLine());

                    if (choice < 1 || choice > 9)
                    {
                        Console.WriteLine("Invalid input. Please select a number between 1 and 9.");
                        Console.ReadKey();
                        continue;
                    }

                    if (board[choice - 1] != 'X' && board[choice - 1] != 'O')
                    {
                        board[choice - 1] = (player == 1) ? 'O' : 'X';
                        flag = CheckWin();
                        if (flag == -1)
                        {
                            player = (player == 1) ? 2 : 1;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Sorry, the cell {choice} is already marked with {board[choice - 1]}.");
                        Console.ReadKey();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    Console.ReadKey();
                }
            }

            Console.Clear();
            Board();
            if (flag == 1)
            {
                Console.WriteLine($"Player {(player == 1 ? 2 : 1)} has won!");
            }
            else
            {
                Console.WriteLine("It's a draw!");
            }


        }

        public static int CheckWin()
        {
            if (board[0] == board[1] && board[1] == board[2])
            {
                return 1;
            }
            else if (board[3] == board[4] && board[4] == board[5])
            {
                return 1;
            }
            else if (board[6] == board[7] && board[7] == board[8])
            {
                return 1;
            }
            else if (board[0] == board[3] && board[3] == board[6])
            {
                return 1;
            }
            else if (board[1] == board[4] && board[4] == board[7])
            {
                return 1;
            }
            else if (board[2] == board[5] && board[5] == board[8])
            {
                return 1;
            }
            else if (board[0] == board[4] && board[4] == board[8])
            {
                return 1;
            }
            else if (board[6] == board[4] && board[4] == board[2])
            {
                return 1;
            }
            else if (board[0] != '1' && board[1] != '2' && board[2] != '3' && board[3] != '4' && board[4] != '5' &&
                     board[5] != '6' && board[6] != '7' && board[7] != '8' && board[8] != '9')
            {
                return 0;
            }
            else
            {
                return -1;
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
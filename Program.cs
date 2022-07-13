using System;
using System.Threading;

namespace cse210_01
{
    class Program
    {
        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int player = 1;
        static int choice;
        static void Main(string[] args)
        {
            do
            {
            // Game intructions!
            // Looks a little weird with the "\n" I know I could have wrote a new line
            // just trying out what works in C#
                Console.WriteLine("Lets play Tic-Tac-Toe!");
                Console.WriteLine("Player 1 is 'X' \nPlayer 2 is 'O'");
                Console.WriteLine("Player 1 goes first. Pick the square you want to play! (1-9)");

                // Checks whos turn it it and if no ones won yet
                if (player % 2 == 0)
                {
                    Console.WriteLine("X's turn to choose a square (1-9): ");
                }
                else
                {
                    Console.WriteLine("Y's turn to choose a square (1-9): ");
                }
                Console.WriteLine("\n");
                // Calls the board
                Board();
                choice = int.Parse(Console.ReadLine());
                // checks to see if the space has already been played or not
                if (arr[choice] != 'X' && arr[choice] != 'O')
                {
                    if (player % 2 == 0)
                    {
                        arr[choice] = 'O';
                        player++;
                    }
                    else
                    {
                        arr[choice] = 'X';
                        player++;
                    }
                }
                else
                
                
                {
                    Console.WriteLine("Sorry the row {0} is already marked with {1}", choice, arr[choice]);
                    Console.WriteLine("\n");
                    Console.WriteLine("Please wait 2 second board is loading again.....");
                    Thread.Sleep(2000);
                }
                // Calls the CheckWinn fuction
                flag = CheckWin();
            }
            while (flag != 1 && flag != -1);
            Console.clear();
            Board();
            
            if (flag == 1)
            // if flag value is 1 then someone has win or
            //means who played marked last time which has win
            {
                Console.WriteLine("Player {0} has won", (player % 2) + 1);
            }
            else// if flag value is -1 the match will be draw and no one is winner
            {
                Console.WriteLine("Draw");
            }
            Console.ReadLine();
        }
    
        // Creates the board that is displayed.
        private static void Board()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);
            Console.WriteLine("     |     |      ");
        }
        private static int CheckWin()
        {

        }
    }
}


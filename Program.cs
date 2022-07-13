// Name:
//  Carter Brown
// Assignment:
//  CSE 210-01, Tic-Tac-Toe

using System;
using System.Threading;

namespace cse210_01
{
    class Program
    {
        // Array
        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int player = 1;
        static int choice;
        // Flag helps check who won. If the value is 1 then someone won
        static int flag = 0;
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
                    Console.WriteLine("O's turn to choose a square (1-9): ");
                }
                else
                {
                    Console.WriteLine("X's turn to choose a square (1-9): ");
                }
                Console.WriteLine("\n");
                // Calls the board
                Board();
                choice = int.Parse(Console.ReadLine());
                // Checks to see if the space has already been played or not
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
                // Call for CheckWin function
                flag = CheckWin();
            }

            // Will loop until all cell are filled or someone won
            while (flag != 1 && flag != -1);
            Console.Clear();
            Board();

            if (flag == 1)
            {
                Console.WriteLine("Player {0} has won", (player % 2) + 1);
            }
            // If flag value is -1 the match will be draw and no one is winner
            else
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
        // Checks to see if someone has won or not
        private static int CheckWin()
        {
        
            //Winning Condition For First Row
            if (arr[1] == arr[2] && arr[2] == arr[3])
            {
                return 1;
            }
            //Winning Condition For Second Row
            else if (arr[4] == arr[5] && arr[5] == arr[6])
            {
                return 1;
            }
            //Winning Condition For Third Row
            else if (arr[6] == arr[7] && arr[7] == arr[8])
            {
                return 1;
            }
            
            //Winning Condition For First Column
            else if (arr[1] == arr[4] && arr[4] == arr[7])
            {
                return 1;
            }
            //Winning Condition For Second Column
            else if (arr[2] == arr[5] && arr[5] == arr[8])
            {
                return 1;
            }
            //Winning Condition For Third Column
            else if (arr[3] == arr[6] && arr[6] == arr[9])
            {
                return 1;
            }
            
            else if (arr[1] == arr[5] && arr[5] == arr[9])
            {
                return 1;
            }
            else if (arr[3] == arr[5] && arr[5] == arr[7])
            {
                return 1;
            }
            // If all the cells or values filled with X or O then its a tie
            else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5] != '5' && arr[6] != '6' && arr[7] != '7' && arr[8] != '8' && arr[9] != '9')
            {
                return -1;
            }
            
            else
            {
                return 0;
            }
        }
    }
}


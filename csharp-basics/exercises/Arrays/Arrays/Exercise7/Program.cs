using System;
using System.Runtime.CompilerServices;

namespace TicTacToe
{
    class Program
    {
        private static char[,] board = new char[3, 3];

        private static void Main(string[] args)
        {
            int myMove = 0;
            int turnCount = 1;

            InitBoard();
            DisplayBoard();
            while (GameEnd() != true) {
                DoTurn(myMove);
                DisplayBoard();
                myMove++;
                turnCount++;
            }
            if (GameEnd())
                Console.WriteLine(myMove % 2 == 0 ? "X is the winner!" : "O is the winner!");
            else if (GameEnd() != true & turnCount == 9){
                Console.WriteLine("Its a tie!");
            }
            Console.ReadKey();
        }
        private static void InitBoard()
        {
            for (var r = 0; r < 3; r++) {
                for (var c = 0; c < 3; c++)
                    board[r, c] = ' ';
            }
        }
        private static void DisplayBoard()
        {
            Console.WriteLine("\n     0   1   2\n");
            Console.WriteLine("  0  " + board[0, 0] + " | " + board[0, 1] + " | " + board[0, 2]);
            Console.WriteLine("    ---+---+---");
            Console.WriteLine("  1  " + board[1, 0] + " | " + board[1, 1] + " | " + board[1, 2]);
            Console.WriteLine("    ---+---+---");
            Console.WriteLine("  2  " + board[2, 0] + " | " + board[2, 1] + " | " + board[2, 2]);
            Console.WriteLine("    ---+---+---\n");

        }

        private static void DoTurn(int num)
        {
            bool move;
            if (num % 2 == 0) {
                Console.WriteLine("Its 'O' turn!");
                do
                {
                    move = true;
                    Console.Write("Please choose your first coordinate (row): ");
                    int x = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Choose your second coordinate (column): ");
                    int y = Convert.ToInt32(Console.ReadLine());
                    if (board[x, y] == ' ' & board[x, y] != 'X')
                        board[x, y] = 'O';
                    else {
                        Console.WriteLine("\nPlease input other free coordinates!\n");
                        move = false;
                    }
                } while (move == false);
            }
            else {
                Console.WriteLine("Its 'X' turn!");
                do
                {
                    move = true;
                    Console.Write("Please choose your first coordinate (row): ");
                    int x = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Choose your second coordinate (column): ");
                    int y = Convert.ToInt32(Console.ReadLine());
                    if (board[x, y] == ' ' & board[x, y] != 'O')
                        board[x, y] = 'X';
                    else {
                        Console.WriteLine("\nPlease input other free coordinates!\n");
                        move = false;
                    }
                } while (move == false);
            }
        }

        private static bool GameEnd() {
            if (board[0, 0] == board[0, 1] && board[0, 0] == board[0, 2] && board[0, 0] != ' ') {
                return true;
            }
            else if (board[0, 0] == board[1, 1] && board[0, 0] == board[2, 2] && board[0, 0] != ' ') {
                return true;
            }
            else if (board[0, 0] == board[1, 0] && board[0, 0] == board[2, 0] && board[0, 0] != ' ') {
                return true;
            }
            else if (board[0, 1] == board[1, 1] && board[0, 1] == board[2, 1] && board[0, 1] != ' ') {
                return true;
            }
            else if (board[0, 2] == board[1, 1] && board[0, 2] == board[2, 0] && board[0, 2] != ' ') {
                return true;
            }
            else if (board[0, 2] == board[1, 2] && board[0, 2] == board[2, 2] && board[0, 2] != ' ') {
                return true;
            }
            else if (board[2, 0] == board[2, 1] && board[2, 0] == board[2, 2] && board[2, 0] != ' ') {
                return true;
            }
            else return false;
        }
    }
}
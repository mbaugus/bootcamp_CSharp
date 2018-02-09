using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static string LookUpMark(int num)
        {
            if (num == 1)
            {
                return "O";
            }
            else if (num == 2)
            {
                return "X";
            }
            else
            {
                return " ";
            }
        }










        static void Main(string[] args)
        {
           
            //TicTacToe();
        }















        static void TicTacToe()
        {
            int[][] board = new int[3][];
            for (int i = 0; i < board.Length; i++)
            {
                board[i] = new int[3] { 0, 0, 0 };
            }

            bool playing = true;
            bool playerOneTurn = true;
            string input = "";
            while(playing == true)
            {
                DisplayBoard(board);
                input = processInput(playerOneTurn);
            }
        }

        static bool checkInput(string input)
        {
            return true;
        }

        static string processInput(bool turn)
        {
            string player1Name = "Player 1";
            string player2Name = "Player 2";
            string input = "";
            do
            {
                var o = new StringBuilder();
                if (turn == true){
                    o.Append(player1Name);
                }
                else{
                    o.Append(player2Name);
                }

                o.Append(", Please enter your position as column,row number.  Enter Q to quit.");
                Console.WriteLine(o.ToString());
                input = Console.ReadLine().ToLower();
            } while (checkInput(input) == false);
            return input;
        }
        
        static void DisplayBoard(int[][] board)
        {
            var output = new StringBuilder();
            output.Append("Tic Tac Toe\n_______\n");
            foreach (var i in board)
            {
                output.Append("|");
                foreach (var j in i)
                {
                    output.Append(LookUpMark(j) + "|");
                }
                output.Append("\n");
            }
            output.Append("_______");
            Console.WriteLine(output);
        }
            
    }

}

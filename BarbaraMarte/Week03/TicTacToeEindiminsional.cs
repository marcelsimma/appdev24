using System.Globalization;
using System.Runtime.ExceptionServices;

namespace BarbaraMarte.Week03;

class TicTacToe
{
    public static void Print()
    {
        string[] grid = new string[9] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        bool isPlayer1Turn = true;
        int numTurns = 0;

        while (!CheckVictory() && numTurns != 9) // meaning that the game will contionue untill someone is Victorious (&& numTurns != 9   while none rached Victory and the number of times hasent reached 9 the game will keep looping
        {
            PrintGrid();
            if (isPlayer1Turn)
            {
                Console.WriteLine("Player 1 turn!");
            }
            else
            {
                Console.WriteLine("Player 2 turn!");
            }
            string choice = Console.ReadLine();

            if (grid.Contains(choice) && choice != "X" && choice != "O") 
            /* && the choice is not the caracter where we are using to represent crosses which we 
            represent with a "X" and the choice is also not the character which we are using to represent the*/ 
            {
                int gridIndex = Convert.ToInt32(choice) - 1;

                if (isPlayer1Turn)
                {
                    grid[gridIndex] = "X";
                }
                else
                {
                    grid[gridIndex] = "O";
                }
                numTurns++;
            }
            isPlayer1Turn = !isPlayer1Turn; 
            // if it is Player 1 turn is true it negate its turn to fals and if its fals it convert it to true. It means we switch now between the players.         

        }

        if (CheckVictory())
        {
            Console.WriteLine("You win!");
        }
        else
        {
            Console.WriteLine("Tie");
        }

        bool CheckVictory()
        {
            // whatever the contents of the fist cell, is equal to the second cell and whatever the contents of the second cell is equal to the third cell. meanint we either have all knots or crosses along the first row        
            bool row1 = grid[0] == grid[1] && grid[1] == grid[2];   // first row: starts with a 0, 1, 2
            bool row2 = grid[3] == grid[4] && grid[4] == grid[5];   // second row: 3, 4, 5
            bool row3 = grid[6] == grid[7] && grid[7] == grid[8];   // third row: 6, 7, 8

            bool col1 = grid[0] == grid[3] && grid[3] == grid[6];   // colem 1 (von oben nach unten) first row
            bool col2 = grid[1] == grid[4] && grid[4] == grid[7];   // second / middle row
            bool col3 = grid[2] == grid[5] && grid[5] == grid[8];   // last row

            bool digDown = grid[0] == grid[4] && grid[4] == grid[8];    // from the upper left corner to the bottom right corner 
            bool digUp = grid[6] == grid[4] && grid[4] == grid[2];      // from the lower left corner to the upper right corner

            return row1 || row2 || row3 || col1 || col2 || col3 || digDown || digUp;

        }

        void PrintGrid()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(grid[i * 3 + j] + "|"); // fomel for the display on the Console. the "|" is for the seperation between the numbers in the same wor
                }
                Console.WriteLine();
                Console.WriteLine("------");    // seperates the rows from each other
            }
        }


    }
}

/*
 int[,] multiDimensionalArray = new int[3, 3]
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }


        };
        for (int i = 0; i < multiDimensionalArray.GetLength(0); i++)
        {
            for (int j = 0; j < multiDimensionalArray.GetLength(1); i++)
            {
                Console.WriteLine(multiDimensionalArray[i, j] + " ");
            }

            Console.WriteLine();
        }
        Console.WriteLine();
        */
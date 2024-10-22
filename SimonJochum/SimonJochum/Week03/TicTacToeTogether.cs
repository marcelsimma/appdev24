using System;
using SimonJochum.Week02;

namespace SimonJochum.Week03
{
    public class TicTacToeTogether
    {
        public static void Start()
        {
            char currentPlayer = 'X';
            int rounds = 0;
            char[,] playground = new char[3, 3]
            {
                {' ', ' ', ' '}, // 0/0, 0/1, 0/2
                {' ', ' ', ' '}, // 1/0, 1/1, 1/2  playground[x,x] = '*'; zum ansprechen
                {' ', ' ', ' '}, // 2/0, 2/1, 2/2
            };

            while (rounds < 9)
            {
                Print(playground);
                Console.WriteLine(currentPlayer + " ist an der Reihe");

                int input;
                do
                {
                    Console.WriteLine("Gib bitte eine Zahl von 0-8 ein.");
                    input = ConsoleInput.ReadNextInt();
                    int row = input / 3;
                    int col = input % 3;
                    if (input >= 0 && input <= 8)
                    {
                        if (playground[row, col] == ' ')
                        {
                            playground[row, col] = currentPlayer;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Dieses Feld ist besetzt");
                        }
                    }
                }
                while (false);

                 rounds++;
                if (CheckWin(playground))
                {
                    Print(playground);
                Console.WriteLine(currentPlayer + " hat gewonnen!");
                break;
                }

                if (currentPlayer == 'X')
                {
                    currentPlayer = 'O';
                }
                else
                {
                    currentPlayer = 'X';
                }
            }
            Console.WriteLine("Das Spiel ist beendet. Keine Züge mehr möglich");
        }
        

        public static void Print(char[,] playground)
        {
            for (int i = 0; i < playground.GetLength(0); i++) // iteriert von oben nach unten (Dimension 0)
            {
                for (int j = 0; j < playground.GetLength(1); j++) // iteriert von links nach rechts (Dimension 1)
                {
                    Console.Write(playground[i, j]);
                }
                Console.WriteLine();
            }
        }
        public static bool CheckWin(char[,] playground)
        {
            // Check Zeilen
            if (playground[0, 0] != ' ' && playground[0, 0] == playground[0, 1] && playground[0, 1] == playground[0, 2])
            {
                return true;
            }
            else if (playground[1, 0] != ' ' && playground[1, 0] == playground[1, 1] && playground[0, 1] == playground[1, 2])
            {
                return true;
            }
            else if (playground[2, 0] != ' ' && playground[2, 0] == playground[2, 1] && playground[2, 1] == playground[2, 2])
            {
                return true;
            }

            // Check Spalten
            else if (playground[0, 0] != ' ' && playground[0, 0] == playground[1, 0] && playground[1, 0] == playground[2, 0])
            {
                return true;
            }
            else if (playground[0, 1] != ' ' && playground[0, 1] == playground[1, 1] && playground[1, 1] == playground[2, 1])
            {
                return true;
            }
            else if (playground[0, 2] != ' ' && playground[0, 2] == playground[1, 2] && playground[1, 2] == playground[2, 2])
            {
                return true;
            }

            // Check Diagonale
            else if (playground[0, 0] != ' ' && playground[0, 0] == playground[1, 1] && playground[1, 1] == playground[2, 2])
            {
                return true;
            }
            else if (playground[0, 2] != ' ' && playground[0, 2] == playground[1, 1] && playground[1, 1] == playground[2, 0])
            {
                return true;
            }
            return false;
        }
    }
}
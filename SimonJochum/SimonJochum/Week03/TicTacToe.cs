using System;
using System.Runtime.InteropServices;

namespace SimonJochum.Week03
{
    public class TicTacToe
    {
        static int[,] board = new int[3, 3]; // Spielfeld 3x3 wird erstellt
        static int currentPlayer = 1; // um den Spieler zu wechseln

        public static void Start()
        {
            int moves = 0;
            bool isRunning = true;

            while (isRunning)
            {
                PrintBoard();
                Console.WriteLine($"Spieler {currentPlayer}, wähle ein Feld (1-9): ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int pos) && pos >= 1 && pos <= 9)
                {
                    if (MakeMove(pos))
                    {
                        moves++;
                        if (CheckWin())
                        {
                            PrintBoard();
                            Console.WriteLine($"Spieler {currentPlayer} gewinnt!");
                            isRunning = false; // Spiel beenden
                        }
                        else if (moves == 9)
                        {
                            PrintBoard();
                            Console.WriteLine("Es ist Unentschieden!");
                            isRunning = false; // Spiel beenden
                        }
                        else
                        {
                            currentPlayer = currentPlayer == 1 ? 2 : 1; // Spieler wird gewechselt
                        }
                    }
                    else
                    {
                        Console.WriteLine("Das Feld ist bereits belegt, bitte wähle ein anderes.");
                    }
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe! Wähle bitte eine Zahl zwischen 1-9.");
                }
            }
        }

        public static void PrintBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == 0)
                    {
                        Console.Write(" 0 "); // leeres Feld
                    }
                    else if (board[i, j] == 1)
                    {
                        Console.Write(" 1 "); // Spieler 1
                    }
                    else
                    {
                        Console.Write(" 2 "); // Spieler 2
                    }
                    if (j < 2)
                    {
                        Console.Write("|"); // bessere Darstellung für das Raster
                    }
                }
                Console.WriteLine();
                if (i < 2)
                {
                    Console.WriteLine("---|---|---"); // bessere Darstellung für das Raster
                }
            }
        }

        public static bool MakeMove(int pos) // der Zug wird überprüft
        {
            int row = (pos - 1) / 3;
            int col = (pos - 1) % 3;

            if (board[row, col] == 0)
            {
                board[row, col] = currentPlayer;
                return true; // solange das Feld leer (0) ist wird das Feld mit dem aktuellen Spieler überschrieben.
            }
            return false;
        }

        public static bool CheckWin() //Gewinnkondition wird überprüft
        {
            for (int i = 0; i < 3; i++)
            {
                if ((board[i, 0] == currentPlayer && board[i, 1] == currentPlayer && board[i, 2] == currentPlayer) ||
                    (board[0, i] == currentPlayer && board[1, i] == currentPlayer && board[2, i] == currentPlayer))
                {
                    return true; // hier werden die Reihen und Spalten überprüft ob überall der gleiche Spieler drinnen steht.
                }
            }
            if ((board[0, 0] == currentPlayer && board[1, 1] == currentPlayer && board[2, 2] == currentPlayer) ||
                (board[0, 2] == currentPlayer && board[1, 1] == currentPlayer && board[2, 0] == currentPlayer))
            {
                return true; // hier werden die Diagonalen überprüft ob der gleiche Spieler drinnen steht.
            }
            return false;
        }
    }
}

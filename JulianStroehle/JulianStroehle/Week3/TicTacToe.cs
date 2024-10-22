using System;
namespace JulianStroehle.Week3
{
    public class TicTacToe
    {
        public static void TicTac()
        {
            char[,] TicTacToe = new char[3, 3];
            bool winner = false;
            int player = 1;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    TicTacToe[i, j] = ' ';
                }
            }
            do
            {
                winner = CheckWinner(TicTacToe, player);
                if (winner == false)
                {
                    try
                    {
                        if (player == 1)
                        {
                            Console.WriteLine("Spieler 1 ist am Zug.");
                            Console.WriteLine("Reihe: (1-3)");
                            int ph = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Spalte: (1-3)");
                            int ph2 = Convert.ToInt32(Console.ReadLine());
                            if (TicTacToe[ph - 1, ph2 - 1] == ' ')
                            {
                                TicTacToe[ph - 1, ph2 - 1] = 'X';
                                player = 2;
                            }
                            else
                            {
                                Console.WriteLine("Feld schon belegt.");
                            }
                        }
                        else if (player == 2)
                        {
                            Console.WriteLine("Spieler 2 ist am Zug.");
                            Console.WriteLine("Reihe: (1-3)");
                            int ph = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Spalte: (1-3)");
                            int ph2 = Convert.ToInt32(Console.ReadLine());
                            if (TicTacToe[ph - 1, ph2 - 1] == ' ')
                            {
                                TicTacToe[ph - 1, ph2 - 1] = 'O';
                                player = 1;
                            }
                            else
                            {
                                Console.WriteLine("Feld schon belegt.");
                            }
                        }
                    }
                    catch (IndexOutOfRangeException)
                    {
                        Console.WriteLine("Zahl zu groß oder zu Klein.");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Bitte eine Zahl eingeben.");
                    }
                    Console.WriteLine();
                    int empty = 0;
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            Console.Write(TicTacToe[i, j] + "\t");
                            if (TicTacToe[i, j] == ' ')
                            {
                                empty++;
                            }

                        }
                        Console.WriteLine("\n");
                    }
                    if (empty == 0)
                    {
                        Console.WriteLine("Gleichstand.");
                        winner = true;
                    }
                }
            }
            while (winner == false);
            /*  }
                static bool CheckWinner(char[,] TicTacToe)
                {
                        int total;
                        for (int row = 0; row < 3; row++)
                        {
                            total = 0;
                            for (int column = 0; column < 3; column++)
                            {
                                if (TicTacToe[row, column] == 'X')
                                {
                                    total += 1;
                                }
                                else if (TicTacToe[row, column] == 'O')
                                {
                                    total -= 1;
                                }
                            }
                            if (total == 3)
                            {
                                Console.WriteLine("Spieler 1 hat gewonnen.");
                                return true;
                            }
                            else if (total == -3)
                            {
                                Console.WriteLine("Spieler 2 hat gewonnen.");
                                return true;
                            }
                        }
                        for (int column = 0; column < 3; column++)
                        {
                            total = 0;
                            for (int row = 0; row < 3; row++)
                            {
                                if (TicTacToe[row, column] == 'X')
                                {
                                    total += 1;
                                }
                                else if (TicTacToe[row, column] == 'O')
                                {
                                    total -= 1;
                                }
                            }
                            if (total == 3)
                            {
                                Console.WriteLine("Spieler 1 hat gewonnen.");
                                return true;
                            }
                            else if (total == -3)
                            {
                                Console.WriteLine("Spieler 2 hat gewonnen.");
                                return true;
                            }
                        }
                        if (TicTacToe[1, 1] == 'X')
                        {
                            if (TicTacToe[0, 0] == 'X' && TicTacToe[2, 2] == 'X' || TicTacToe[2, 0] == 'X' && TicTacToe[0, 2] == 'X')
                            {
                                Console.WriteLine("Spieler 1 hat gewonnen.");
                                return true;
                            }
                        }
                        else if (TicTacToe[1, 1] == 'O')
                        {
                            if (TicTacToe[0, 0] == 'O' && TicTacToe[2, 2] == 'O' || TicTacToe[2, 0] == 'O' && TicTacToe[0, 2] == 'O')
                            {
                                Console.WriteLine("Spieler 2 hat gewonnen.");
                                return true;
                            }
                        }
                        return false; */
        }
        static bool CheckWinner(char[,] TicTacToe, int player)
        {
            for (int i = 0; i < 3; i++)
            {

                // Zeile
                if (TicTacToe[i, 0] != ' ' && TicTacToe[i, 0] == TicTacToe[i, 1] && TicTacToe[i, 1] == TicTacToe[i, 2])
                {
                    switch (player)
                    {
                        case 2: Console.WriteLine("Spieler 1 hat gewonnen."); break;
                        case 1: Console.WriteLine("Spieler 2 hat gewonnen."); break;
                    }
                    return true;
                }

                // Spalte
                if (TicTacToe[0, i] != ' ' && TicTacToe[0, i] == TicTacToe[1, i] && TicTacToe[1, i] == TicTacToe[2, i])
                {
                    switch (player)
                    {
                        case 2: Console.WriteLine("Spieler 1 hat gewonnen."); break;
                        case 1: Console.WriteLine("Spieler 2 hat gewonnen."); break;
                    }
                    return true;
                }
            }

            // Diagonale
            if (TicTacToe[1, 1] != ' ' && (TicTacToe[0, 0] == TicTacToe[1, 1] && TicTacToe[1, 1] == TicTacToe[2, 2] || TicTacToe[1, 1] == TicTacToe[0, 2] && TicTacToe[1, 1] == TicTacToe[2, 0]))
            {
                switch (player)
                {
                    case 2: Console.WriteLine("Spieler 1 hat gewonnen."); break;
                    case 1: Console.WriteLine("Spieler 2 hat gewonnen."); break;
                }
                return true;
            }
            return false;
        }
    }
}

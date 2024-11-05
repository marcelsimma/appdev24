using System;
using LucasSchiemann.Week03;

namespace LucasSchiemann.Week03
{

    public class TicTacToe
    {
        public static void Start()
        {
            // Teil 1: Init Playground

            char[,] playground = new char[3, 3] {
                {' ', ' ', ' '}, // 0;0  0;1  0;2
                {' ', ' ', ' '},  // 1;0  1;1  1;2
                {' ', ' ', ' '}  // 2;0  2;1  2;2
            };

            //playground[1, 2] = '*'; 

            //Spielerabfrage
            Console.WriteLine("Wer ist SpielerX?");
            string SpielerX = Console.ReadLine();
            Console.WriteLine("Wer ist SpielerO?");
            string SpielerO = Console.ReadLine();

            string currentPlayer = SpielerX; // oder 'O'
            int rounds = 0;

            while (rounds < 9)
            {
                Print(playground);

                // Teil 2: User Input
                Console.WriteLine(currentPlayer + " ist an der Reihe.");

                /*
                            Console.WriteLine("Bitte eine Zahl zwischen 0 und 8 eingeben:");
                            int input = ConsoleInput.ReadNextInt();

                            if (input < 0 || input > 8)
                            {
                                Console.WriteLine("Bitte eine Zahl zwischen 0 und 8 eingeben:");
                                input = ConsoleInput.ReadNextInt();
                            }

                            // --> Kommentierter Bereich entspricht der do-while Schleife.
                */

                int input = 0; // zulässiger Wertebereich: [0; 8]

                do
                {
                    Console.WriteLine("Bitte eine Zahl zwischen 0 und 8 eingeben:");
                    //input = ConsoleInput.ReadNextInt();
                    
                    /*
                     Spalte:  0  1  2
                     Zeile 0: 0, 1, 2
                     Zeile 1: 3, 4, 5
                     Zeile 2: 6, 7, 8
                    */

                    int zeile = input / 3;
                    int spalte = input % 3;

                    if (input >= 0 && input <= 8)
                    {
                        // Prüfung, ob Feld bereits besetzt
                        if (playground[zeile, spalte] == ' ')
                        {
                            playground[zeile, spalte] = Convert.ToChar(currentPlayer);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Dieses Feld ist besetzt.");
                        }
                    }
                } while (true);
                
                // Prüfen, ob der aktuelle Spieler gewonnen hat.
                if (CheckWinner(playground))
                {
                    Print(playground);
                    Console.WriteLine(currentPlayer + " hat gewonnen!");
                    break;
                } 

                // Spieler tauschen für nächste Runde
                if (currentPlayer == SpielerX)
                {
                    currentPlayer = SpielerO;
                }
                else
                {
                    currentPlayer = SpielerX;
                }

                rounds++;
            }

            Console.WriteLine("Das Spiel ist beendet. Keine Züge mehr möglich.");

        }

        public static void Print(char[,] playground)
        {
            for (int i = 0; i < playground.GetLength(0); i++)
            {
                for (int j = 0; j < playground.GetLength(1); j++)
                {
                    Console.Write(playground[i, j]);
                }
                Console.WriteLine();
            }
        }

        public static bool CheckWinner(char[,] playground)
        {

            // Zeilen
            if (playground[0, 0] != ' ' && playground[0, 0] == playground[0, 1] && playground[0, 1] == playground[0, 2])
            {
                return true;
            }
            else if (playground[1, 0] != ' ' && playground[1, 1] == playground[1, 2] && playground[1, 1] == playground[1, 0])
            {
                return true;
            }
            else if (playground[2, 0] != ' ' && playground[2, 0] == playground[2, 1] && playground[2, 1] == playground[2, 2])
            {
                return true;
            }
            //Spalten
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

            // Diagonal
            else if (playground[0, 0] != ' ' && playground[0, 0] == playground[1, 1] && playground[1, 1] == playground[2, 2])
            {
                return true;
            }
            else if (playground[0, 2] != ' ' && playground[0, 2] == playground[1, 1] && playground[1, 1] == playground[2, 0])
            {
                return true;
            }

            return false; // oder false
        }
    }
}
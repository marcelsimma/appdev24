using System;
using System.Security.Cryptography.X509Certificates;
using MarcelSimma.Week02;

namespace MarcelSimma.Week03
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

            char currentPlayer = 'X'; // oder 'O'

            while (true)
            {
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

                int input; // zulässiger Wertebereich: [0; 8]

                do
                {
                    Console.WriteLine("Bitte eine Zahl zwischen 0 und 8 eingeben:");
                    input = ConsoleInput.ReadNextInt();

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
                            playground[zeile, spalte] = currentPlayer;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Dieses Feld ist besetzt.");
                        }
                    }
                } while (true);

                // Spieler tauschen für nächste Runde
                if (currentPlayer == 'X')
                {
                    currentPlayer = 'O';
                }
                else
                {
                    currentPlayer = 'X';
                }

                Print(playground);
            }
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
    }
}
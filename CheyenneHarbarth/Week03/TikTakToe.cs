using System;
using System.Security.Cryptography.X509Certificates;
using CheyenneHarbarth.Week02;

namespace CheyenneHarbarth.Week03
{

    class TikTakToe
    {
        //Code laut Aufgabe:
        public static void StartGame()
        {
            char[,] playground = new char[3, 3]                             //ein Array das 3 Zeilen und 2 Spalten haben
            {
                { ' ',' ',' '},             //0,0    0,1     0,2
                { ' ',' ',' '},             //1,0    1,1     1,2
                { ' ',' ',' '}              //2,0    2,1     2,2
            };

            /*Console.WriteLine("Wer ist SpielerX?");
            string SpielerX = Console.ReadLine();
            Console.WriteLine("Wer ist SpielerO?");
            string SpielerO = Console.ReadLine();*/
            char currentPlayer = 'X';
            int rounds = 0;

            while (rounds < 9)
            {
                Print(playground);
                Console.WriteLine(currentPlayer + " ist an der Reihe!");

                do
                {
                    Console.WriteLine("Bitte gib eine Zahl zwischen 0 und 8 eingeben:");
                    int input = ConsoleInput.ReadInt();

                    int zeile = input / 3;
                    int spalte = input % 3;

                    if (input >= 0 && input <= 8)
                    {
                        if (playground[zeile, spalte] == ' ')
                        {
                            playground[zeile, spalte] = currentPlayer;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Das Feld ist schon belegt!");
                        }
                    }
                }
                while (true);

                //Prüfen ob schon jemand gewonnen hat
                if (CheckWinner(playground))
                {
                    Print(playground);
                    Console.WriteLine(currentPlayer + " hat gewonnen!");
                    break;
                }

                //Spieler tauschen für nächste Runde
                if (currentPlayer == 'X')
                {
                    currentPlayer = 'O';
                }
                else
                {
                    currentPlayer = 'X';
                }

                rounds++;
            };

            Console.WriteLine("Das Spiel ist beendet.");


        }
        public static void Print(char[,] playground)                        //da "playground" in der anderen Methode definiert wurde, müssen wir sie hier noch als Übergabeparameter mitgeben
        {
            for (int i = 0; i < playground.GetLength(0); i++)               //mit 0 gehen wir über die Zeilen, die Zeilen sind die 0. Dimension, wir beginnen ja immer bei 0 zu zählen
            {
                for (int j = 0; j < playground.GetLength(1); j++)           //mit 1 gehen wir über die Spalten, die Spalten sind die 1. Dimension
                {
                    Console.Write(playground[i, j] + " | ");
                }
                Console.WriteLine();
                Console.WriteLine("-----------");
            }
        }

        public static bool CheckWinner(char[,] playground)
        {
            if (playground[0, 0] != ' ' && playground[0, 0] == playground[0, 1] && playground[0, 1] == playground[0, 2])                    //1. Zeile
            {
                return true;
            }
            else if (playground[1, 0] != ' ' && playground[1, 0] == playground[1, 1] && playground[1, 1] == playground[1, 2])               //2. Zeile
            {
                return true;
            }
            else if (playground[2, 0] != ' ' && playground[2, 0] == playground[2, 1] && playground[2, 1] == playground[2, 2])               //3. Zeile
            {
                return true;
            }
            else if (playground[0, 0] != ' ' && playground[0, 0] == playground[1, 0] && playground[1, 0] == playground[2, 0])               //1. Spalte
            {
                return true;
            }
            else if (playground[0, 1] != ' ' && playground[0, 1] == playground[1, 1] && playground[1, 1] == playground[2, 1])               //2. Spalte
            {
                return true;
            }
            else if (playground[0, 2] != ' ' && playground[0, 2] == playground[1, 2] && playground[1, 2] == playground[2, 2])               //3. Spalte
            {
                return true;
            }
            else if (playground[0, 0] != ' ' && playground[0, 0] == playground[1, 1] && playground[1, 1] == playground[2, 2])               //1. Diagonale
            {
                return true;
            }
            else if (playground[2, 0] != ' ' && playground[2, 0] == playground[1, 1] && playground[1, 1] == playground[0, 2])               //2. Diagonale
            {
                return true;
            }
            return false;
        }
    }
}
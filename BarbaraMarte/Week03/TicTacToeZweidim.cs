using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using BarbaraMarte.Week02;

namespace BarbaraMarte.Week03;

class TicTacToeZweidimensional
{
    public static void Start()
    {
        int round = 0;
        // Teil 1 Userinput
        Char[,] playground = new char[3, 3]{        // der Beistrich in der Eckigen klammer bedeutet dass es Zweidimensional ist
       {' ', ' ', ' '}, // 0;0 0;1 0;2 
       {' ', ' ', ' '}, // 1;0 1;1 1;2
       {' ', ' ', ' '}  // 2;0 2;1 2;2 
        };

        //playground[1, 2] = '*';


        char curentPlayer = 'X'; // oder 'O'

        while (round <= 9)
        {
            Print(playground);
            Console.WriteLine(curentPlayer + "it's his turn:");

            /*  
            Genau das gleiche wie die do while Schleife.
            Console.WriteLine("Please enter a number between 0 and 8");
            int input = ConsoleInput.ReadNextInt();

            if (input < 0 || input > 8)
            {

            }*/

            //Teil 2: Unser Input


            int input; // zulaessiger Wertbereich [0; 8]

            do
            {
                Console.WriteLine("Please enter a number between 0 and 8");
                input = ConsoleInput.ReadNextInt();

                /*
                Spalte   0  1  2
                Zeile 0: 0, 1, 2
                Zeile 1: 3, 4, 5
                Zeile 2: 6, 7, 8
                */

                int zeile = input / 3;
                int spalte = input % 3;


                if (input >= 0 && input <= 8)
                {
                    // check if the spot is taken
                    if (playground[zeile, spalte] == ' ')
                    {
                        playground[zeile, spalte] = curentPlayer;
                        break;
                    }

                    else
                    {
                        Console.WriteLine("This spot is already taken");
                    }
                }
            } while (true);


            // checking if the actual player won
            if (CheckWinner(playground))
            {
                Print(playground);
                Console.WriteLine(curentPlayer + "You won");
                break;
            }

            // switch the player for the next round
            if (curentPlayer == 'X')
            {
                curentPlayer = 'O';
            }
            else
            {
                curentPlayer = 'X';
            }
            round++;

        }
        Console.WriteLine("The game is over, no more movements available");


    }
    public static void Print(char[,] playground)
    {

        for (int i = 0; i < playground.GetLength(0); i++) // Zeilen. Die Null bezieht sich auf die erste Diemensio
        {
            for (int j = 0; j < playground.GetLength(1); j++)   // Spalten. Die Eins bezieht sich auf die zweite Dimension
            {
                Console.Write(playground[i, j]);
            }
            Console.WriteLine();
        }

    }

    public static bool CheckWinner(char[,] playground)
    {   // Zeile
        // auch wenn drei Lehrzeichen sind kat keiner gewonnen
        if (playground[0, 0] != ' ' && playground[0, 0] == playground[0, 1] && playground[0, 1] == playground[0, 2]) // when you use && both sides have to be true otehwerwise it is false (boolse Algebra) 
        {
            return true;
        }
        else if (playground[1, 0] != ' ' && playground[1, 0] == playground[1, 1] && playground[1, 1] == playground[1, 2])
        {
            return true;
        }
        else if (playground[2, 0] != ' ' && playground[2, 0] == playground[2, 1] && playground[2, 1] == playground[2, 2])
        {
            return true;
        }
        // Spalte
        else if (playground[1, 0] != ' ' && playground[0, 0] == playground[1, 0] && playground[1, 0] == playground[2, 1])
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

        // diagonal
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

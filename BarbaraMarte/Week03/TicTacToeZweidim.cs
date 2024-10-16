using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using BarbaraMarte.Week02;

namespace BarbaraMarte.Week03;

class TicTacToeZweidimensional()
{
    public static void Start()
    {
        // Teil 1 Userinput
        Char[,] playground = new char[3, 3]{        // der Beistrich in der Eckigen klammer bedeutet dass es Zweidimensional ist
       {' ', ' ', ' '}, // 0;0 0;1 0;2 
       {' ', ' ', ' '}, // 1;0 1;1 1;2
       {' ', ' ', ' '}  // 2;0 2;1 2;2 
        };
        //playground[1, 2] = '*';


        char curentPlayer = 'X'; // oder 'O'
        do
        {
            Console.WriteLine("Please enter a number between 0 and 8");
            input = ConsoleInput.ReadNextInt();
            /*  
            Genau das gleiche wie die do while Schleife.
            Console.WriteLine("Please enter a number between 0 and 8");
            int input = ConsoleInput.ReadNextInt();

            if (input < 0 || input > 8)
            {

            }*/

            //Teil 2: Unser Input
            Console.WriteLine(curentPlayer + "it's his turn:");

            int input; // zulaessiger Wertbereich [0; 8]

            int zeile = input / 3;
            int spalte = input % 3;

            // check if the spot is taken
            if (input >= 0 || input <= 8)
            {
                if (playground[zeile, spalte] == ' ')
                {
                    playground[zeile, spalte] = currentPlayer;
                }
                else
                {
                    Console.WriteLine("This spot is already taken");
                    input = -1;
                }
            }

        } while (true);



        // switch the player for the next round
        if (curentPlayer == 'X')
        {
            curentPlayer = 'O';
        }
        else
        {
            curentPlayer = 'X';
        }

    }
    public static void Print(char[,] playground)
    {

        for (int i = 0; i < playground.GetLength(0); i++) // Zeilen. Die Null bezieht sich auf die erste Diemensio
        {
            for (int j = 0; i < playground.GetLength(1); j++)   // Spalten. Die Eins bezieht sich auf die zweite Dimension
            {
                Console.WriteLine(playground[i, j]);
            }
            Console.WriteLine();
        }

    }

}

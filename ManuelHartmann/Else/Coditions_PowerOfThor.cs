using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 * ---
 * Hint: You can use the debug stream to print initialTX and initialTY, if Thor seems not follow your orders.
 **/
class Player
{
    static void Main(string[] args)
    {
        string[] inputs = Console.ReadLine().Split(' ');
        int lightX = int.Parse(inputs[0]); // the X position of the light of power
        int lightY = int.Parse(inputs[1]); // the Y position of the light of power
        int initialTx = int.Parse(inputs[2]); // Thor's starting X position
        int initialTy = int.Parse(inputs[3]); // Thor's starting Y position

        // game loop
        while (true)
        {
            int remainingTurns = int.Parse(Console.ReadLine()); // The remaining amount of turns Thor can move. Do not remove this line.

            int difX = lightX - initialTx;
            int difY = lightY - initialTy;
            int tmp = 0;

            // Überprüft, ob der Wert positiv, negativ oder 0 ist.
            switch (Math.Sign(difX))
            {
                case 1:
                    // Überprüft, ob der Wert positiv, negativ oder 0 ist.
                    switch (Math.Sign(difY))
                    {
                        // Beide Zahlen sind positiv.
                        case 1:
                            if (difX == difY)
                            {
                                for (int i = 0; i < difX; i++)
                                {
                                    // A single line providing the move to be made: N NE E SE S SW W or NW
                                    Console.WriteLine("SE");
                                }
                            }
                            else
                            {
                                tmp = difX - difY;
                                if (difX > difY)
                                {
                                    for (int i = 0; i < Math.Abs(tmp); i++)
                                    {
                                        // A single line providing the move to be made: N NE E SE S SW W or NW
                                        Console.WriteLine("E");
                                    }
                                    for (int j = 0; j < difY; j++)
                                    {
                                        // A single line providing the move to be made: N NE E SE S SW W or NW
                                        Console.WriteLine("SE");
                                    }
                                }
                                else
                                {
                                    tmp = tmp * (-1);
                                    for (int i = 0; i < Math.Abs(tmp); i++)
                                    {
                                        // A single line providing the move to be made: N NE E SE S SW W or NW
                                        Console.WriteLine("S");
                                    }
                                    for (int j = 0; j < difX; j++)
                                    {
                                        // A single line providing the move to be made: N NE E SE S SW W or NW
                                        Console.WriteLine("SE");
                                    }
                                }
                            }
                            break;
                        // X ist positiv und Y ist negativ
                        case -1:
                            // Vorzeichen wir nicht betrachtet.
                            if (Math.Abs(difX) == Math.Abs(difY))
                            {
                                for (int i = 0; i < difX; i++)
                                {
                                    // A single line providing the move to be made: N NE E SE S SW W or NW
                                    Console.WriteLine("NE");
                                }
                            }
                            else
                            {
                                tmp = difX - difY;
                                if (Math.Abs(difX) > Math.Abs(difY))
                                {
                                    for (int i = 0; i < Math.Abs(tmp); i++)
                                    {
                                        // A single line providing the move to be made: N NE E SE S SW W or NW
                                        Console.WriteLine("E");
                                    }
                                    for (int j = 0; j < Math.Abs(difY); j++)
                                    {
                                        // A single line providing the move to be made: N NE E SE S SW W or NW
                                        Console.WriteLine("SE");
                                    }
                                }
                                else
                                {
                                    for (int i = 0; i < Math.Abs(tmp); i++)
                                    {
                                        // A single line providing the move to be made: N NE E SE S SW W or NW
                                        Console.WriteLine("S");
                                    }
                                    for (int j = 0; j < difX; j++) // X ist hier positiv.
                                    {
                                        // A single line providing the move to be made: N NE E SE S SW W or NW
                                        Console.WriteLine("SE");
                                    }
                                }
                            }
                            break;
                        // X ist positiv und Y ist 0
                        case 0:
                            for (int i = 0; i < difX; i++)
                            {
                                // A single line providing the move to be made: N NE E SE S SW W or NW
                                Console.WriteLine("E");
                            }
                            break;
                    }
                    break;



                case -1:
                    // Überprüft, ob der Wert positiv, negativ oder 0 ist.
                    switch (Math.Sign(difY))
                    {
                        // X ist negativ und Y ist positiv
                        case 1:
                            // Vorzeichen wir nicht betrachtet.
                            if (Math.Abs(difX) == Math.Abs(difY))
                            {
                                for (int i = 0; i < Math.Abs(difX); i++)
                                {
                                    // A single line providing the move to be made: N NE E SE S SW W or NW
                                    Console.WriteLine("SW");
                                }
                            }
                            else
                            {
                                // X ist negativ -> deshalb +
                                tmp = difX + difY;
                                if (Math.Abs(difX) > Math.Abs(difY))
                                {
                                    for (int i = 0; i < Math.Abs(tmp); i++)
                                    {
                                        // A single line providing the move to be made: N NE E SE S SW W or NW
                                        Console.WriteLine("W");
                                    }
                                    for (int j = 0; j < Math.Abs(difY); j++)
                                    {
                                        // A single line providing the move to be made: N NE E SE S SW W or NW
                                        Console.WriteLine("SW");
                                    }
                                }
                                else
                                {
                                    for (int i = 0; i < Math.Abs(tmp); i++)
                                    {
                                        // A single line providing the move to be made: N NE E SE S SW W or NW
                                        Console.WriteLine("S");
                                    }
                                    for (int j = 0; j < Math.Abs(difX); j++)
                                    {
                                        // A single line providing the move to be made: N NE E SE S SW W or NW
                                        Console.WriteLine("SW");
                                    }
                                }
                            }
                            break;
                        // Beide sind negativ.
                        case -1:
                            // Vorzeichen wir nicht betrachtet.
                            if (Math.Abs(difX) == Math.Abs(difY))
                            {
                                for (int i = 0; i < Math.Abs(difX); i++)
                                {
                                    // A single line providing the move to be made: N NE E SE S SW W or NW
                                    Console.WriteLine("NW");
                                }
                            }
                            else
                            {
                                // Muss erneut addiert werden, weil BEIDE NEGATIV sind.
                                tmp = difX + difY;
                                if (Math.Abs(difX) > Math.Abs(difY))
                                {
                                    for (int i = 0; i < Math.Abs(tmp); i++)
                                    {
                                        // A single line providing the move to be made: N NE E SE S SW W or NW
                                        Console.WriteLine("W");
                                    }
                                    for (int j = 0; j < Math.Abs(difY); j++)
                                    {
                                        // A single line providing the move to be made: N NE E SE S SW W or NW
                                        Console.WriteLine("NW");
                                    }
                                }
                                else
                                {
                                    for (int i = 0; i < Math.Abs(tmp); i++)
                                    {
                                        // A single line providing the move to be made: N NE E SE S SW W or NW
                                        Console.WriteLine("N");
                                    }
                                    for (int j = 0; j < Math.Abs(difX); j++)
                                    {
                                        // A single line providing the move to be made: N NE E SE S SW W or NW
                                        Console.WriteLine("NW");
                                    }
                                }
                            }
                            break;
                        // X ist negativ und Y ist 0
                        case 0:
                            for (int i = 0; i < Math.Abs(difX); i++)
                            {
                                // A single line providing the move to be made: N NE E SE S SW W or NW
                                Console.WriteLine("W");
                            }
                            break;
                    }
                    break;



                case 0:
                    // Überprüft, ob der Wert positiv, negativ oder 0 ist.
                    switch (Math.Sign(difY))
                    {
                        // X ist 0 und Y ist positiv
                        case 1:
                            for (int i = 0; i < Math.Abs(difY); i++)
                            {
                                // A single line providing the move to be made: N NE E SE S SW W or NW
                                Console.WriteLine("S");
                            }
                            break;
                        // X ist 0 und Y ist NEGATIV
                        case -1:
                            for (int i = 0; i < Math.Abs(difY); i++)
                            {
                                // A single line providing the move to be made: N NE E SE S SW W or NW
                                Console.WriteLine("N");
                            }
                            break;
                        // BEIDE 0
                        case 0:
                            Console.WriteLine("Already on spot!");
                            break;
                    }
                    break;
            }
        }
    }
}
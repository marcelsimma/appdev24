using System;
using System.Security.Cryptography.X509Certificates;

namespace MagdalenaMueller.Week03
{
    public class TikTakToe
    {
        public static void TikTakToeProgramm()
        {
            int[,] spielfeld = new int[3,3];
            bool game = true;
            
            while(game == true)
            {    
                DarwField(spielfeld);
                CheckIfWon(spielfeld, game);

                DrawPlayer1(spielfeld, game);
                DarwPlayer2(spielfeld,game);
            }
        }
                public static void DarwField(int[,] spielfeld)
                {
                    Console.Clear();
                    Console.WriteLine("    A | B | C ");
                    Console.WriteLine("   -----------");
                    Console.WriteLine($"1 | {spielfeld[0, 0]} | {spielfeld[0,1]} | {spielfeld[0,2]}");
                    Console.WriteLine("  |-----------");
                    Console.WriteLine($"2 | {spielfeld[1, 0]} | {spielfeld[1,1]} | {spielfeld[1,2]}");
                    Console.WriteLine("  |-----------");
                    Console.WriteLine($"3 | {spielfeld[2, 0]} | {spielfeld[2,1]} | {spielfeld[2,2]}");
                    Console.WriteLine();
                }

                public static void DrawPlayer1(int[,] spielfeld, bool game)
                {
                    Console.WriteLine("Spieler1 ist dran! \nGib ein Feld ein(bsp. 1A, 3B,...): ");
                    string player1Input = Console.ReadLine();
                
                    switch(player1Input)
                    {
                        case "1A":
                            if (spielfeld[0,0] != 2)
                            {
                                spielfeld[0,0] = 1;                            
                            }
                            DarwField(spielfeld);
                            break;
                        case "1B":
                            if (spielfeld[0,1] != 2)
                            {
                                spielfeld[0,1] = 1;                            
                            }
                            DarwField(spielfeld);
                            break;
                        case "1C":
                            if (spielfeld[0,2] != 2)
                            {
                                spielfeld[0,2] = 1;                           
                            }
                            DarwField(spielfeld);
                            break;
                        case "2A":
                            if (spielfeld[1,0] != 2)
                            {
                                spielfeld[1,0] = 1;                          
                            }
                            DarwField(spielfeld);
                            break;
                        case "2B":
                            if (spielfeld[1,1] != 2)
                            {
                                spielfeld[1,1] = 1;                            
                            }
                            DarwField(spielfeld);
                            break;
                        case "2C":
                            if (spielfeld[1,2] != 2)
                            {
                                spielfeld[1,2] = 1;                        
                            }
                            DarwField(spielfeld);
                            break;
                        case "3A":
                            if (spielfeld[2,0] != 2)
                            {
                                spielfeld[2,0] = 1;
                            }
                            DarwField(spielfeld);
                            break;
                        case "3B":
                            if (spielfeld[2,1] != 2)
                            {
                                spielfeld[2,1] = 1;
                            }
                            DarwField(spielfeld);
                            break;
                        case "3C":
                            if (spielfeld[2,2] != 2)
                            {
                                spielfeld[2,2] = 1;
                            }
                            DarwField(spielfeld);
                            break;
                    }
                    CheckIfWon(spielfeld, game);
                }

                public static void DarwPlayer2(int[,] spielfeld, bool game)
                {
                    Console.WriteLine("Spieler2 ist dran! \nGib ein Feld ein(bsp. 1A, 3B,...): ");
                string player2Input = Console.ReadLine();
                switch(player2Input)
                {
                    case "1A":
                        if(spielfeld[0,0] != 1)
                        {
                            spielfeld[0,0] = 2;                            
                        }
                        DarwField(spielfeld);
                        break;
                    case "1B":
                        if(spielfeld[0,1] != 1)
                        {
                            spielfeld[0,1] = 2;
                        }
                        DarwField(spielfeld);
                        break;
                    case "1C":
                        if(spielfeld[0,2] != 1)
                        {
                            spielfeld[0,2] = 2;                            
                        }
                        DarwField(spielfeld);
                        break;
                    case "2A":
                        if(spielfeld[1,0] != 1)
                        {
                            spielfeld[1,0] = 2;                            
                        }
                        DarwField(spielfeld);
                        break;
                    case "2B":
                        if(spielfeld[1,1] != 1)
                        {
                            spielfeld[1,1] = 2;                        
                        }
                        DarwField(spielfeld);
                        break;
                    case "2C":
                        if(spielfeld[1,2] != 1)
                        {
                            spielfeld[1,2] = 2;                            
                        }
                        DarwField(spielfeld);
                        break;
                    case "3A":
                        if(spielfeld[2,0] != 1)
                        {
                            spielfeld[2,0] = 2;                            
                        }
                        DarwField(spielfeld);
                        break;
                    case "3B":
                        if(spielfeld[2,1] != 1)
                        {
                            spielfeld[2,1] = 2;                            
                        }
                        DarwField(spielfeld);
                        break;
                    case "3C":
                        if(spielfeld[2,2] != 1)
                        {
                            spielfeld[2,2] = 2;                           
                        }
                        DarwField(spielfeld);
                        break;
                    }

                    CheckIfWon(spielfeld, game);
                }
                public static void CheckIfWon(int[,] spielfeld, bool game)
                {
                    //Zeile Überprüfen
                    if((spielfeld[0,0] == 1 && spielfeld[0,1] == 1 && spielfeld[0,2] == 1) || (spielfeld[0,0] == 2 && spielfeld[0,1] == 2 && spielfeld[0,2] == 2))
                    {
                        Console.WriteLine("Game WON!");
                        game = false;
                    }
                    if ((spielfeld[1,0] == 1 && spielfeld[1,1] == 1 && spielfeld[1,2] == 1) || (spielfeld[1,0] == 2 && spielfeld[1,1] == 2 && spielfeld[1,2] == 2))
                    {
                        Console.WriteLine("Game WON!");
                        game = false;
                    }
                    if((spielfeld[2,0] == 1 && spielfeld[2,1] == 1 && spielfeld[2,2] == 1) || (spielfeld[2,0] == 2 && spielfeld[2,1] == 2 && spielfeld[2,2] == 2))
                    {
                        Console.WriteLine("Game WON!");
                        game = false;
                    }
                    //Spalte Überprüfen
                    if((spielfeld[0,0] == 1 && spielfeld[1,0] == 1 && spielfeld[2,0] == 1) || (spielfeld[0,0] == 2 && spielfeld[1,0] == 2 && spielfeld[2,0] == 2))
                    {
                        Console.WriteLine("Game WON!");
                        game = false;
                    }
                    if((spielfeld[0,1] == 1 && spielfeld[1,1] == 1 && spielfeld[2,1] == 1) || (spielfeld[0,1] == 2 && spielfeld[1,1] == 2 && spielfeld[2,1] == 2))
                    {
                        Console.WriteLine("Game WON!");
                        game = false;
                    }
                    if((spielfeld[0,2] == 1 && spielfeld[1,2] == 1 && spielfeld[2,2] == 1) || (spielfeld[0,2] == 2 && spielfeld[1,2] == 2 && spielfeld[2,2] == 2))
                    {
                        Console.WriteLine("Game WON!");
                        game = false;
                    }
                    //Diagonale Überpfrüfen
                    if((spielfeld[0,0] == 1 && spielfeld [1,1] == 1 && spielfeld [2,2] == 1)||(spielfeld[0,0] == 2 && spielfeld [1,1] == 2 && spielfeld [2,2] == 2))
                    {
                        Console.WriteLine("Game WON!");
                        game = false;
                    }
                    if((spielfeld[0,2] == 1 && spielfeld[1,1]== 1 && spielfeld[2,0] == 1) || (spielfeld[0,2] == 2 && spielfeld[1,1]== 2 && spielfeld[2,0] == 2))
                    {
                        Console.WriteLine("Game WON!");
                        game = false;
                    }
                    if(spielfeld[0,0] != 0 && spielfeld[0,1] != 0 && spielfeld[0,2] != 0 && spielfeld[1,0] != 0 && spielfeld [1,1] != 0 && spielfeld[1,2] != 0 && spielfeld[2,0] != 0&& spielfeld[2,1] != 0 && spielfeld[2,2] != 0)
                    {
                        Console.WriteLine("Game OVER \nNiemand hat gewonnen!");
                        game = false;
                    }
    }
}       }
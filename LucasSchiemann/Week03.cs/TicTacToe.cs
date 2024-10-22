using System;
using System.Security.Cryptography.X509Certificates;

namespace LucasSchiemann.Week03;

public static class TikTakToe
{
    public static void Processor()
    {
        char[,] playground = new char[3, 3]{
            {' ',' ',' '},
            {' ',' ',' '},
            {' ',' ',' '}
        };
        char currentPlayer = 'X';
        while (true)
        {Console.WriteLine(currentPlayer + "ist grad an der reihe");
        playground[1, 2] = '*';
        int inputUser;      
        do 
        {       Console.WriteLine("gib ein an welcher stelle du dein zeichen Plazieren möchtest");
        inputUser = Convert.ToInt32(Console.ReadLine());

        int zeile = inputUser / 3;
        int spalte = inputUser % 3;
        if (playground[zeile,spalte] == ' ')
        {
            playground[zeile,spalte] = currentPlayer;
            break;
        }else{
            Console.WriteLine("Dieses Feld ist besetzt.");            
        }
        playground[zeile,spalte] = currentPlayer;
        if (currentPlayer=='X'){
            currentPlayer = '0';
            }else{
                currentPlayer = 'X';
            }
        }while(inputUser >= 0 || inputUser <= 8);
    
       
        }
        }
    public static void Print(char [,] playground)
    {
        for (int i = 0; i < playground.GetLength(0); i++)
        {
            for (int j = 0; j < playground.GetLength(1); j++)
            {
                Console.WriteLine(playground[i, j]);


            }

        }
    }
    public static void CheckWinner(char[,]playground){
        



        
    }
}
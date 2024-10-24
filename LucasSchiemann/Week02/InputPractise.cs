using System;
using System.Security.Cryptography.X509Certificates;

namespace LucasSchiemann.Week02;

public class shoppingList
{
    public static void ReadList()
    {
        int counter = 0;
        while (counter >4)
        {
            counter ++;
        Console.WriteLine("Geb ein was du als "+counter+". einkaufen willst");
        string einKauf = Console.ReadLine();
        Console.WriteLine("Gib die anzahl an");
        int AnzahlKauf = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Geb ein was du als "+counter+". einkaufen willst");
        if (counter == 1)
        {
            string ersterEinkauf = "";
            int ersteAnzahl;
            einKauf = ersterEinkauf;
            ersteAnzahl = AnzahlKauf;
        }
        }
        /*
        if (counter == 2 )
        {
            string zgeiterEinkauf = "";
            int zweiteAnzahl;
            zweiterEinkauf = einKauf;
            zweiteAnzahl = AnzahlKauf;



        }
        }
        */
    
    }
    
    
   

}
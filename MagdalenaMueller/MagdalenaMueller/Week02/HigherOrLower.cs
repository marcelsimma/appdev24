using System;
using System.Collections;
using System.Data;
using System.Linq.Expressions;

namespace MagdalenaMueller.Week02
{
    public class HigherOrLower
    {
        public static void HoRGame()
        {
            //Random Generieren
            Random random = new Random();
            int randomNumber = random.Next(0, 100);

            bool isGameWon = false;

            Console.WriteLine("Erraten die Zahl zwischen 0 - 100");
            while(isGameWon == false)
            {
                Console.WriteLine("Gib eine Zahl ein:");
       
                string userInput = Console.ReadLine();
                int nummber;

                if  (!int.TryParse(userInput, out nummber) || nummber < 0|| nummber > 100)// falsche eingabe
                {
                    Console.WriteLine("Ungültige eingabe! Es muss eine Zahl eingegeben werden die zwischen 0 - 100 liegen");
                    continue;
                }
                else if (randomNumber > nummber) // nummer kleiner wie random
                {
                    Console.WriteLine("Die Zahl ist größer");
                }    
                else if (randomNumber < nummber) // nummer größer wie random
                {
                    Console.WriteLine("Die Zahl ist kleiner");
                }  
                else if (randomNumber == nummber) // nummer und rnadom gleich = Gewonnen
                {
                    Console.WriteLine("Du hast die Zahl Gefunden !!!");
                    isGameWon = true;
                } 
                
                Console.WriteLine();
            }
        }
    }
}
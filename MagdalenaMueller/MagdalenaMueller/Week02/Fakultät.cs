using System;

namespace MagdalenaMueller.Week02
{
    public class Fakultät
    {
        public static void CalcFacultät()
        {
            
            Console.WriteLine("Die Fakultät 20 wird so ausgerechnet: ");

            Console.Write("20! = "); //Anfang der Berechnung
            long ergebniss = 1;
            for (int i = 1;i <= 20; i++)
            {
                ergebniss *= i; //Ergebniss wird überschrieben um auf die Lösung zu kommen 
                
                // if und else um den Rechenweg auszugeben
                if (i == 20)
                {
                    Console.Write($"{i} = "); // Wenn die Letzte Zahl erreicht wird 
                }
                else
                {
                    Console.Write($"{i} * "); // Ausgabe der Multiplikation
                }
            }
            Console.WriteLine(ergebniss);
        }
    }
}
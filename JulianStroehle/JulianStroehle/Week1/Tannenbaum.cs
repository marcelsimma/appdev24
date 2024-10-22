using System;
namespace JulianStroehle.Week1{
    public class TannenbaumA{
        public static void Tannenbaum()
        {
            // Nutzereingabe für Größe
            Console.WriteLine("Größe: ");
            int size = Convert.ToInt32(Console.ReadLine());

            // Zuweisung der Variablen
            char star = '*';
            char zero = '0';
            char plus = '+';
            int GrosseZahlen = 0;
            double sizeRounded = size/3*2;
            int rounded = Convert.ToInt32(Math.Round (sizeRounded));

            // Aufbau des Baums
            for (int counter = 0; counter <= size; counter++)
            {
                // Spitze des Baums
                if (counter == 0)
                {
                    Console.Write(new string(' ', size*2) + star + new string(' ', size*2));
                }

                // Unter der Spitze bis zu den Christbaumkugeln
                if (counter < size && counter > 0)
                {
                    Console.Write(new string(' ', size*2-counter) + new string(star, counter*2+1) + new string(' ', size*2-counter));
                }

                // Kugeln anschreiben
                if (counter == size)
                {
                    Console.Write(new string(' ', size+1));
                    for (int k = 0; k < size; k++)
                    {
                        Console.Write(zero + " ");
                    }
                    Console.Write(new string(' ', size));
                    Console.WriteLine();
                    int j = 0;

                    // Stamm berechnen
                    if (counter > 20)
                    {
                        GrosseZahlen++;
                    }
                    while (j < size/4){
                        Console.Write(new string(' ', size+GrosseZahlen+rounded+2) + new string(plus, (size+1)/2) + new string(' ', size+rounded+2));
                        Console.WriteLine();
                        j++;
                    }
                   
                }

                // Zeilenumbruch
                Console.WriteLine();
            }
        }
    }
}
using System;

namespace CheyenneHarbarth.Week02
{
    class Bubblesort
    {
        public static void SortBubble()
        {
            int[] zahlenreihe = {1, 2, 3, 4, 5, 6, 7, 8};               //Array wird deklariert und initialisiert
            Random random = new Random();                               //Random-Generator wird erstellt

            for (int i = 0; i < zahlenreihe.Length; i++)
            {
                int rand = random.Next(1, 8);                           //Zufallszahlen zwischen 1 und 8 fürs Array ausgewählt
                //jede Zahl soll aber nur 1x vorkommen
                int tmp1 = zahlenreihe[i];
                zahlenreihe[i] = zahlenreihe[rand];
                zahlenreihe[rand] = tmp1;
            }

            Console.WriteLine("Unsortiertes Array:");                   //Ausgabe des unsortierten Arrays
            foreach (int zahl in zahlenreihe)
            {
                Console.WriteLine(zahl);
            }

            for (int i = 0; i < zahlenreihe.Length - 1; i++)            //hier findet das Bubble-Sorting statt, 
            {                                                           //äußere for-Schleife sorgt dafür, dass das ganze Array durchläuft
                for (int j = 0; j < zahlenreihe.Length - i - 1; j++)    //innere for-Schleife ist für das Tauschen zuständig, dass -i bedeutet: nach jeder Iteration der Schleifen wurde ja eine Zahl an ihren richtigen Platz gesetzt,
                {                                                       //dass heißt diese Zahl muss nicht mehr verglichen werden, deshalb -i, so fallen von hinten gezählt immer mehr Positionen weg die man noch Tauschen muss
                    if (zahlenreihe[j] > zahlenreihe[j + 1])            //hier wird abgefragt, ob die Zahl an der momentanen Position größer ist als die Zahl an der nächsten Position
                    {
                        // Tauschen
                        int temp = zahlenreihe[j];                      //damit keine Position gelöscht wird, müssen wir einen Zwischenspeicher einrichten
                        zahlenreihe[j] = zahlenreihe[j + 1];
                        zahlenreihe[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Sortiertes Array:");                     //Ausgabe des sortierten Arrays
            foreach (int zahl in zahlenreihe)
            {
                Console.WriteLine(zahl);
            }
        }
    }
}



namespace ManuelHartmann.Week03
{
    public class InsertionSortList_noDefaultFunktion    // Ascending
    {
        static int[] numbers = new int[20]
        {
              19, 17, 11, 4, 1,
              6, 2, 8, 5, 10,
              7, 9, 13, 3,12,
              16, 14, 18, 15, 20
        };
        public static void Start()
        {
            SortArray();
            OutputArray(numbers);   // Global angelegtes Array 'numbers' wird mitgegeben.
        }
        //  Rueckgabewert ist das Array 'numbers'.
        public static int[] SortArray()
        {
            int listLength = numbers.Length;    //  Laenge des Arrays
            for (int i = 1; i < listLength; i++)    //  Arritiert durch jedes Schleifenelement 1. Mal.
            {
                int tempValue = numbers[i]; /* Speichert aufsteigend aus der Liste das naechste Element, welches in der Range von 'i'
                                               der groesse nach eingeordnet wird. Sprich von der Arraygroesse[i] abwaerst wird
                                               ueberprueft, wo es rein passt.  */
                Console.WriteLine($"Stelle= {i} Wird in tempValue abgelegt= {tempValue}");  //......... Veranschaulichung
                int j = i - 1;  // While-Schleife startet mit der ueberpruefung, ob es vorherige Element groesser ist.

                /* Startet mit der ueberpruefung, ob das vorherige Array-Element groesser ist. Dann geht man je While-Schleife
                   immer eine Stelle weiter zurueck und ueberprueft. */
                while (j >= 0 && numbers[j] > tempValue)
                {
                    /*  Im ersten Durchlauf wird die im 'tempValue' gespeicherte Zahl ueberschrieben. (Somit gibt es dann bis zum
                     *  Schluss der 'while-Schleife' eigentlich einen leeren Platzhalter (besser gesagt, eine Zahl doppelt), welcher
                     *  am Ende der 'while-Schleife' dann gefuellt wird. Die einzelnen Array-Eintraege hinter dem Array-Start [i] 
                     *  werden so lange nach Oben (rechts) geschoben, bis die gespeicherte Variable ('tempValue'[i]) nicht mehr 
                     *  groesser ist, als die Variable eine Stelle davor (weiter links) im Array.  */
                    numbers[j + 1] = numbers[j];
                    j--;
                }
                numbers[j + 1] = tempValue; //  'tempValue' wird der groesse entsprechen in der Rang von 'i' abgelegt.
                Console.WriteLine($"{tempValue} zurück auf Stelle {j+1}\n");    //......... Veranschaulichung
                OutputArray(numbers);   //......... Veranschaulichung
                Console.WriteLine("\n \n"); //......... Veranschaulichung
            }
            return numbers;
        }
        //  Der Methode wird das sortierte Array 'numbers' mitgegeben.
        public static void OutputArray(int[] numbers)
        {
            for (int ii = 0; ii < numbers.Length - 1; ii++)
            {
                Console.Write(numbers[ii]);
                // Komma und Zeilenumbruch (bis auf die letzte Zeile)
                if (ii < numbers.Length - 2)
                {
                    Console.Write(", \n");
                }
            }
        }
    }
}


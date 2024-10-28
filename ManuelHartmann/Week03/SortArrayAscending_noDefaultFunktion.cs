

namespace ManuelHartmann.Week03
{
    public class SortArrayAscending_noDefaultFunktion   // Methode 'BubbleSort'
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
            /*  Die enthaltene for-Schleife muss so oft ausgefuert werden, wie Elemente in der Liste enthalten sind,
                da sich immer nur zwei Arrayinhalte miteinander tauschen! Somit kann gewaerleistet werden, dass die kleinste
                Zahl an den Anfang kommen kann und umgekehrt.   */
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                /* Listenlaenge wird standardmaessig um -1 reduziert und MINUS i, weil pro/Durchlauf zwei Stellen miteinander 
                   verglichen werden. -> somit (-2/pro Durchlauf). */
                for (int j = 0; j < numbers.Length - 1 - i; j++)
                {
                    if (numbers[j] > numbers[j + 1])    /* Wenn der Inhalt der ersten Kachel groesser ist, als der Inhalt der 
                                                           Inhalt der darauffolgenden Kachel -> tausche die Kacheln miteinander. */
                    {
                        int temp = numbers[j];          // Kachelinhalt [j] wird in temp abgelegt.
                        numbers[j] = numbers[j + 1];    // Kachelinhalt von [j+1] wird in [j] gelegt.
                        numbers[j + 1] = temp;          // Kachelinhalt von temp[j] wird in [j+1] gelegt.
                    }
                }
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


using System;


namespace MarcelSimma.Week02
{
    class KaufmaennischesRunden
    {
        static void Start()
        {
            // Beispielaufruf der Methode
            double zahl = 123.45678;
            double gerundeteZahl = RundeAufZweiNachkommastellenOhneMath(zahl);
            Console.WriteLine($"Die kaufmännisch gerundete Zahl ist: {gerundeteZahl}");
        }

        // Methode, die eine Kommazahl manuell auf zwei Nachkommastellen rundet
        static double RundeAufZweiNachkommastellenOhneMath(double zahl)
        {
            // Zahl mit 100 multiplizieren, um zwei Nachkommastellen als ganze Zahl zu betrachten
            double grosseZahl = zahl * 100;

            // Kaufmännisch runden (Falls die Ziffer nach der zweiten Nachkommastelle >= 0.5 ist, aufrunden)
                //12345.678 - 12345 = 0.678
            if (grosseZahl - (int)grosseZahl >= 0.5)
            {
                // 12346   = 12345           + 1
                grosseZahl = (int)grosseZahl + 1;
            }
            else
            {
                grosseZahl = (int)grosseZahl;
            }

            // Ergebnis zurück in zwei Nachkommastellen umwandeln
            return grosseZahl / 100;
                   // 12346 / 100 = 123.46
        }
    }

}


// Berechnung mit %
// 12345 % 10 = 5
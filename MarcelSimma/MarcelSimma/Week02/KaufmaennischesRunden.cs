using System;


namespace MarcelSimma.Week02
{
    class KaufmaennischesRunden
    {
        static void Main()
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
            double faktor = zahl * 100;

            // Kaufmännisch runden (Falls die Ziffer nach der zweiten Nachkommastelle >= 0.5 ist, aufrunden)
            if (faktor - (int)faktor >= 0.5)
            {
                faktor = (int)faktor + 1;
            }
            else
            {
                faktor = (int)faktor;
            }

            // Ergebnis zurück in zwei Nachkommastellen umwandeln
            return faktor / 100;
        }
    }

}

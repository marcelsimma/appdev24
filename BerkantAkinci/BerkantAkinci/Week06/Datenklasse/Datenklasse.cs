

namespace BerkantAkinci.Week06 {

    public class Datenklasse {

        // static: Klassenattribut oder -methode
        // non static: Instanzattribut oder -methode
        public static void Start() {

            // 1. Result Klasse erstellen

            // 2. Integer-Array erstellen und mit Werten befüllen.

            // leeres Array erstellen
            int[] zahlen = new int[2];

            // 3. das Array mit zufälligen Zahlen füllen
            Random random = new Random();

            for (int i = 0; i < zahlen.Length; i++) {
                zahlen[i] = random.Next(0, 100);
            }

            // Array auf der Console ausgeben.
            foreach(int zahl in zahlen) {
                System.Console.WriteLine(zahl);
            }
            
            // 4. Calculate Methode implementieren und ausführen
            Result res = Calculate(zahlen);
            Console.WriteLine();
            
            // 5. Ergebnisse auf der Konsole ausgeben
            Console.WriteLine(res.Min);
            Console.WriteLine(res.Max);
            Console.WriteLine(res.Avg);

        }

        public static Result Calculate(int[] zahlen2) {
            // Result Objekt erstellen
            Result res = new Result();
            
            // Minimum ausrechnen
            int tmpMin = 100;
            foreach (int zahl in zahlen2) {
                if (zahl < tmpMin) {
                    tmpMin = zahl;
                }
            }

            res.Min = tmpMin;

            // Maximum ausrechnen
            int tmpMax = 0;
            foreach (int zahl in zahlen2) {
                if (zahl > tmpMax) {
                    tmpMax = zahl;
                }
            }

            res.Max = tmpMax;

            // Durchschnitt berechnen
            int sum = 0;
            foreach(int zahl in zahlen2) {
                sum += zahl;
            }

            // Mit "(double)" erzwinge ich, dass keine Integer-Divison durchgeführt wird. 
            res.Avg = (double)sum / zahlen2.Length;


            return res;
        }
    }
}
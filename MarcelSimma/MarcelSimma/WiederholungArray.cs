using System;
using System.ComponentModel;
using System.Net.Http.Headers;

namespace MarcelSimma.Week05 {

    public class WiederholungArrays {

        public static void Start() {

            
            // Variante 1

            /*
            int[] alter = new int[6];

            alter[0] = 14; // n-6 = 0
            alter[1] = 45; // n-5 = 1
            alter[2] = 12; // n-4 = 2
            alter[3] = 23; // n-3 = 3
            alter[4] = 70; // n-2 = 4
            alter[5] = 99; // n-1 = 5
            */

            //alter[7] = 101;
            // Funktioniert nicht, da die Größe eines Array nicht veränderbar ist.

            // Variante 2
            int[] alter = {
                14, 45, 12, 23
            };

            alter[3] = 44;
            alter[0] = 0;



            string str = "Fatma";
            char c = 'c';

            /*
            For-Schleife: Verwendet einen Zählindex i. 
            Dieser Index beginnt bei i=0 und geht i=n-1. 
            Mit dem Index greife ich auf die einezlenen Elemente im Array zu. 
            */
            for (int i = 0; i < alter.Length; i++) {
                System.Console.WriteLine(alter[i]);
            }

            Console.WriteLine();

            /*
            Foreach: Arbeitet ohne Zählindex i.
            Anstelle dessen greift die Foreach-Schleife direkt auf den Wert an einer bestimmten Stelle im Array zu.
            Dieser Wert ist über die Variable int a abrufbar.
            */
            foreach (int a in alter) {
                System.Console.WriteLine(a);
            }

            // Iteration 0: a = 14
            // Iteration 1: a = 45
            // Iteration 2: a = 12
            // ...
            // Iteration n-1: a = 99

            Console.WriteLine();

            System.Console.WriteLine(alter.Length); // n = 6 = Anzahl der Werte = Anzahl der Iterationen


            // größeres Array erstellen und Inhalte aus kleinerem alten Array übernehmen

            // ursprüngliches IKEA Regal
            string[] farben = {
                "schwarz",
                "blau", // Index = [1]
                "grün",
                "rot"
            };

            // neues IKEA Regal, dass größer ist

            string[] farben2 = new string[farben.Length + 2];

            System.Console.WriteLine(farben.Length);
            System.Console.WriteLine(farben2.Length);

            for ( int i = 0;  i < farben.Length; i++) {
                farben2[i] = farben[i];
            }
            
            farben2[4] = "orange";
            farben2[5] = "lila";

            foreach (string farbe in farben2) {
                System.Console.WriteLine(farbe);
            }
            

        }
    }
}
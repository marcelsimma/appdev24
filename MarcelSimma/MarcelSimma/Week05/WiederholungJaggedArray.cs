using System;
using System.ComponentModel;
using System.Net.Http.Headers;

namespace MarcelSimma.Week05
{

    public class WiederholungJaggedArrays
    {

        public static void Start()
        {
            string[][] farben = new string[4][];

            farben[0] = ["blau"];
            farben[1] = ["schwar", "grün", "rot", "blau"];
            farben[2] = new string[2];
            farben[3] = new string[1];

            farben[2][0] = "blau";
            farben[2][1] = "schwarz";

            farben[3][0] = "lila";

            // i ist die Zählvariable für die Zeilen
            // i = 0 --> ich beginne in der ersten Zeile
            for (int i = 0; i < farben.Length; i++) {
                // j ist die Zählvariablen für die Spalten
                for (int j = 0; j < farben[i].Length; j++) {
                    // Mit der Kombination aus i, j bzw. Zeilenindex und Spaltenindex kann ich auf die Werte zugreifen.
                    System.Console.Write(farben[i][j] + "  |  ");
                }
                Console.WriteLine();
            }

        }
    }
}
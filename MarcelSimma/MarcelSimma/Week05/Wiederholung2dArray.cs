using System;
using System.ComponentModel;
using System.Net.Http.Headers;

namespace MarcelSimma.Week05
{

    public class Wiederholung2dArrays
    {

        public static void Start()
        {

            // Array erstellen Variante 1
            //                           [Zeilen, Spalten]
            string[,] farben = new string[3, 2];
            /*
            Durch den "," signalisiere ich dem Compiler, dass es ein 2d Array sein soll. 
            Vor und nach dem Beistrich muss eine Größe stehen.
            */

            /*
                0,0 = blau     0,1 = hellgrün
                1,0 = rot      1,1 = grün
                2,0 = schwarz  2,1 = blau
            */

            farben[0, 0] = "blau";
            farben[0, 1] = "hellgrün";
            farben[1, 0] = "rot";
            farben[1, 1] = "grün";
            farben[2, 0] = "schwarez";
            farben[2, 1] = "blau";

            // Array erstellen Variante 2
            string[,] farben2 = {
                {"blau", "hellgrün"},
                {"rot", "grün"},
                {"schwarz", "blau"}
            };


            // 3 Zeilen = 3 Teller mit jeweils 2 Tassen = 2 Werten
            for (int i = 0; i < farben.GetLength(0); i++)
            {
                for (int j = 0; j < farben.GetLength(1); j++)
                {
                    System.Console.Write(farben[i, j] + "     |");
                }
                Console.WriteLine();
            }


        }
    }
}
using System;

namespace BerkantAkinci.Ubueng
{

    class EinDimenArray
    {

        public static void PrintArray()
        {
            //altes Array
            string[] sortimentAlt = { "Müsli", "Schoko", "Apfel", "Banane", "Gurke", "Tomate", "Brot", "Mehl", "Wasser", "Cola" };

            //neues Array, welches größer ist
            string[] sortimentNeu = new string[sortimentAlt.Length + 5];
            sortimentNeu[10] = "Stift";
            sortimentNeu[11] = "Block";
            sortimentNeu[12] = "Kaugummi";
            sortimentNeu[13] = "Nüsse";
            sortimentNeu[14] = "Kuchen";

            //umschreiben wir die alten Werte aus dem alten Array ins neue Array
            for (int i = 0; i < sortimentAlt.Length; i++)
            {
                sortimentNeu[i] = sortimentAlt[i];
            }

            // gehen wir duch jeden Wert im neuen Array und geben ihn aus
            foreach (string sortiment in sortimentNeu)
            {
                System.Console.WriteLine(sortiment);
            }
        }
    }
}
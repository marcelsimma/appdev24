using System;

namespace JonasWehinger.Week05
{
    public class Arrays
    {
        public static void Araryswiederholung()
        {
            
            string[] Sortiment = {
                "Käse",
                "Kekse",
                "Chips",
                "Energy",
                "Kaugummi",
                "Milch",
                "Brötchen",
                "Früchte",
                "Leberkas",
                "Eier"
            };

            
            string[] Sortiment2 = new string[Sortiment.Length + 5];

            
            for (int i = 0; i < Sortiment.Length; i++)
            {
                Sortiment2[i] = Sortiment[i];
            }

            
            Sortiment2[10] = "Eis";
            Sortiment2[11] = "Brot";
            Sortiment2[12] = "RedBull";
            Sortiment2[13] = "Schnitzel";
            Sortiment2[14] = "Ice Tea";

            
            for (int i = 0; i < Sortiment2.Length; i++)
            {
                Console.WriteLine(Sortiment2[i]);
            }
        }
    }
}

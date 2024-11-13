using System;

namespace JonasWehinger.Week05{

    public class jaggedArray{

        public static void Start(){

            string[][] jaggedArray = new string[5][];
            jaggedArray[0] = new string[] { "Wasser", "Apfelsaft", "Orangensaft" };
            jaggedArray[1] = new string[] { "Brot" };
            jaggedArray[2] = new string[] { "Salat", "Tomaten", "Paprika", "Kürbis", "Gruke", "Aubergine"};
            jaggedArray[3] = new string[] {" "};
            jaggedArray[5] = new string[] {"Cheddar", "Edamer", "Würstle"};

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.WriteLine();
            }
        }
    }
}

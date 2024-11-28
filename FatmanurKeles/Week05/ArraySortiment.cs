using System;
using System.Diagnostics.Metrics;

namespace FatmanurKeles.Week05
{
    public class ArraySortiment
    {
        public static void Start()
        {
            string[] sortiment = {"Milch", "Butter", "Zucker", "Öl", "Mehl", "Brot", "Salz", "Apfel", "Birne", "Banane"};

            string[] sortiment2 = new string[sortiment.Length + 5];

            for (int i = 0; i < sortiment.Length; i++)
            {
                sortiment2[i] = sortiment[i];
            }

            sortiment2[10] = "Joghurt";
            sortiment2[11] = "Ei";
            sortiment2[12] = "Fleisch";
            sortiment2[13] = "Salat";
            sortiment2[14] = "Tomate";

            foreach (string sorte in sortiment2)
            {
                Console.WriteLine(sorte);
            }
        }
    }
}
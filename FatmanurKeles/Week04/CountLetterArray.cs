using System;
using System.Diagnostics.Metrics;

namespace FatmanurKeles.Week04
{
    public class CountLetterArray
    {
        public static void Start()
        {
    
            string input = "Dieser Text wird später untersucht & die Anzahl der Zeichen wird ausgegeben";
            
            //input wird in char umgewandelt
            char[] textArray = input.ToCharArray();

            //counter kann bis 65536 zählen, weil es weltweit so viele Zeichen gibt
            int[] counter = new int[65536];

            //ASCI tabelle z.B: Zeichen 2 hat den int-Wert von 50
            foreach (char c in textArray)
            {
                counter[c]++;
            }

            for (int i = 0; i < counter.Length; i++)
            {
                if (counter[i] > 0) 
                {
                    Console.WriteLine("Der Buchstabe " + (char)i + ", repräsentiert durch den ASCIT Code" + counter[i]);
                }
            }
        }
    }
}
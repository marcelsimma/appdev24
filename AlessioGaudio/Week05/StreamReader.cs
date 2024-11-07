using System;
using System.IO;

namespace Lernenn
{
    public class Streamm
    {
        public static void ReadFile()
        {

            // Array vom typ string
            string[] Zahlen;


            using (StreamReader zahl = new StreamReader("/Users/ALGA/Documents/input.txt"))
            {
                string WholeLine = zahl.ReadToEnd();
                Zahlen = WholeLine.Split('\n');
            }

            using (StreamWriter stw = new StreamWriter("/Users/ALGA/Documents/output.txt"))
            {
                stw.WriteLine(Zahlen[0]);
                for (int i = 1; i < Zahlen.Length; i++)
                {
                    stw.WriteLine(i + ". " + Zahlen[i]);
                }
                int temp = Zahlen.Length -1;
                stw.WriteLine("Die Wurzel der Zahlen ist" + temp);
            }


        }



    }

}


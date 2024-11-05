using System;
using System.IO;

namespace BerkantAkinci.Week05
{

    class Datenstroeme
    {

        public static void PrintDatenstroeme()
        {
            Teilnehmerliste1();
            Teilnehmerliste2();
            Teilnehmerliste3();
        }


        public static void Teilnehmerliste1()
        {
            using (StreamReader str1 = new StreamReader("\\Users\\BAU26336\\OneDrive - Julius Blum GmbH\\Allgemeines\\Dokumente\\input.txt"))
            {
                int zahl = 0;
                string wholefile = str1.ReadToEnd();

                foreach (char tmp in wholefile)
                {
                    System.Console.Write(tmp);
                }
            }
        }

        public static void Teilnehmerliste2()
        {


        }

        public static void Teilnehmerliste3()
        {


        }
    }
}
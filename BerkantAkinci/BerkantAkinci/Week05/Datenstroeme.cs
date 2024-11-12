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
            using (StreamReader read1 = new StreamReader("\\Users\\BAU26336\\OneDrive - Julius Blum GmbH\\Allgemeines\\Dokumente\\input.txt"))
            {
                string wholefile = read1.ReadToEnd();
                System.Console.Write(wholefile);
            }

            using (StreamWriter wrt1 = new StreamWriter("\\Users\\BAU26336\\OneDrive - Julius Blum GmbH\\Allgemeines\\Dokumente\\output.txt"))
            {

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
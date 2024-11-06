using System;
using System.IO;

namespace MarcelSimma.Week05.Streams
{

    public static class StreamsExample
    {

        public static void Start()
        {


            //ReadFile();

            using (StreamWriter str = new StreamWriter("/Users/marcel/Documents/assets/output.txt")) {
                str.WriteLine("Teilnehmer 3");
                str.WriteLine("Joachim");
                str.Write("Clemens");
                str.Write("Jakob");

            }

            Console.WriteLine("fertig");



        }


        public static void ReadFile()
        {
            // Using sorgt dafür, dass die Ressource (die Datei) im System als von uns verwendet markiert wird. Sobald wird den Codeblock wieder verlassen, wird die Ressource (die Datei) wieder freigegeben. 
            using (StreamReader str = new StreamReader("/Users/marcel/Documents/assets/input.txt"))
            {

                // einzelne Zeichen auslesen
                int c = str.Read();
                Console.WriteLine((char)c);

                // eine Zeile auslesen
                string line = str.ReadLine();
                Console.WriteLine(line);

                // die ganze Datei auslesen
                string wholeFile = str.ReadToEnd();
                Console.WriteLine(wholeFile);


            }
        }

        public static void WriteFile()
        {
            using (StreamWriter str = new StreamWriter("/Users/marcel/Documents/assets/output.txt")) {
                
                // schreibt den Text mit Zeilenumbruch
                str.WriteLine("Teilnehmer 3");
                str.WriteLine("Joachim");
                // schreibt den Text ohne Zeilenumbruch am Ende
                str.Write("Clemens");
                str.Write("Jakob");

            }

            Console.WriteLine("fertig");
        }
    }
}
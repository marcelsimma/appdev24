using System;
using System.ComponentModel.DataAnnotations;
using System.IO;

namespace BerkantAkinci.Week07
{
    public class RepetitionStreams
    {
        public static void Start()
        {
            using (StreamReader str = new StreamReader(@"\Users\BAU26336\OneDrive - Julius Blum GmbH\Digitaler Campus\input.txt"))
            {
                List<string[]> teilnehmer = new List<string[]>();

                while (true)
                {
                    string line = str.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    else
                    {
                        teilnehmer.Add(line.Split(" "));
                    }
                }

                foreach (string[] t in teilnehmer)
                {
                    System.Console.WriteLine(t[0].Trim() + " " + t[1].Trim());
                }
            }
        }

        public static void Start2()
        {
            //ReadFile();

            using (StreamWriter str = new StreamWriter(@"\Users\BAU26336\OneDrive - Julius Blum GmbH\Digitaler Campus\output.txt"))
            {
                str.WriteLine("Teilnehmer 3");
                str.WriteLine("Joachim");
                str.Write("Clemens");
                str.Write("Jakob");

                str.Flush();

                str.Close();
            }

            Console.WriteLine("fertig");

        }

        public static void ReadFile()
        {
            // Using sorgt dafür, dass die Ressource (die Datei) im System als von uns verwendet markiert wird. Sobald wird den Codeblock wieder verlassen, wird die Ressource (die Datei) wieder freigegeben. 
            using (StreamReader str = new StreamReader("/Users/BAU26336/OneDrive - Julius Blum GmbH/Digitaler Campus/input.txt"))
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
            using (StreamWriter str = new StreamWriter(@"\Users\BAU26336\OneDrive - Julius Blum GmbH\Digitaler Campus\output.txt"))
            {
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

namespace ManuelHartmann.Week05
{
    public static class StreamExamples
    {
        static string split = new string('-', 12);
        static string[,] multiDimString =
                {
                    {" ", " ", " "},
                    {" ", " ", " "},
                    {" ", " ", " "},
                    {" ", " ", " "}
                };
        public static void Start()
        {
            Console.WriteLine("Give me your fileName!");
            string respond = Console.ReadLine();
            //ReadFile();
            //ReadFileLine();
            //WriteFile(ReadFileLine(respond));
            //WriteFileCalc(ReadFileLine(respond));
            ReadFileLineExtended(respond);

        }
        public static void ReadFile()
        {
            // Mit dem 'using' wird erst auf die Datei zugegriffen, wenn sie benoetigt wird und nach Abschluss die Verbindung wieder getrennt.
            using (StreamReader str = new StreamReader("C:/Users/harmanu/Downloads/DigitalCampus/input.txt"))
            {
                // Das gesamte File auslesen.
                string wholeFile = str.ReadToEnd();
                Console.WriteLine(wholeFile);

                // Eine Zeile auslesen.
                string line = str.ReadLine();
                Console.WriteLine(line);

                // Einzelne Zeichen auslesen.
                int c = str.Read();
                Console.WriteLine((char)c); // Wird nicht mehr der ASCII-Code ausgegeben, sonder der Char selbst.
            }
            Console.WriteLine("fertig");
        }
        public static string[] ReadFileLine(string respond)
        {
            // Mit dem 'using' wird erst auf die Datei zugegriffen, wenn sie benoetigt wird und nach Abschluss die Verbindung wieder getrennt.
            using (StreamReader str = new StreamReader($"C:/Users/harmanu/Downloads/DigitalCampus/{respond}.txt"))
            {
                string wholeFile = str.ReadToEnd();
                string[] strings = wholeFile.Split('\n');

                Console.WriteLine(strings[0]);
                Console.WriteLine(split);
                for (int i = 1; i < strings.Length; i++)
                {
                    Console.WriteLine($"{i}. {strings[i]}");
                }
                return strings;
            }
        }
        public static void WriteFile(string[] strings)
        {
            // Mit dem 'using' wird die Datei, auf die ich derzeitig zugreiffe so lange gesperrt, bis ich sie wieder schließe.
            using (StreamWriter str = new StreamWriter("C:/Users/harmanu/Downloads/DigitalCampus/output.txt"))
            {
                str.WriteLine($"{strings[0]}");
                str.WriteLine(split);
                for (int i = 1; i < strings.Length; i++)
                {
                    str.WriteLine($"{i}. {strings[i]}");
                }
                str.WriteLine(split);
                str.WriteLine($"{strings.Length - 1} participants");
                //str.Write("Clemens");
            }
        }
        public static void WriteFileCalc(string[] strings)
        {
            using (StreamWriter str = new StreamWriter("C:/Users/harmanu/Downloads/DigitalCampus/output.txt"))
            {
                str.WriteLine($"{strings[0]}");
                str.WriteLine(split);
                for (int i = 1; i < strings.Length; i++)
                {
                    if (int.TryParse(strings[i], out int value))
                    {
                        str.WriteLine($"{value}² = {value * value}");
                    }
                    else
                    {
                        str.WriteLine($"{strings[i]}");
                    }
                }
            }
        }
        public static void ReadFileLineExtended(string respond)
        {
            // Mit dem 'using' wird erst auf die Datei zugegriffen, wenn sie benoetigt wird und nach Abschluss die Verbindung wieder getrennt.
            using (StreamReader str = new StreamReader($"C:/Users/harmanu/Downloads/DigitalCampus/{respond}.txt"))
            {
                string wholeFile = str.ReadToEnd(); // Liest das komplette File in einen String ein.
                string[] strings = wholeFile.Split(' ');    // Splittet den String bei jedem Leerzeichen auf und ins -> Array.

                for (int i = 0; i < strings.Length; i += 0) // Splittet das eindimensionale Array in ein Zweidimensionales auf.
                {
                    multiDimString[i / 3, i % 3] = strings[i++];
                    multiDimString[i / 3, i % 3] = strings[i++];
                    multiDimString[i / 3, i % 3] = strings[i++];
                }
                Console.WriteLine($"{multiDimString.GetLength(0)},  {multiDimString.GetLength(1)}");    // Ueberpruefung.

                for (int i = 0; i < multiDimString.GetLength(0); i++)   // Ueberpruefung.
                {
                    for (int j = 0; j < multiDimString.GetLength(1); j++)
                    {
                        Console.WriteLine(multiDimString[i, j]);
                    }
                }
            }

            WriteFileFormatting();
        }
        public static void WriteFileFormatting()
        {
            using (StreamWriter str = new StreamWriter("C:/Users/harmanu/Downloads/DigitalCampus/outputNew.txt"))
            {
                float tmp = 0;
                for (int i = 0; i < multiDimString.GetLength(0); i++)   // Anzahl Zeilen im Array.
                {
                    if (i > 0)  // Erste Zeile soll anders behandelt werden.
                    {
                        if (float.TryParse(multiDimString[i, 1], out float value))
                        {
                            tmp = (float)Math.Round(value, 2);  // Ergebnis wird auf zwei Kommastellen gerundet.
                        }
                        str.Write(string.Format("{0,-15} | {1,-10:N2} | {2,8}", // Tabellarische Darstellung
                            multiDimString[i, 0], tmp, multiDimString[i, 2]));
                    }
                    else
                    {
                        str.WriteLine(string.Format("{0,-13} | {1,-10:N2} | {2,8}", // Tabellarische Darstellung
                            multiDimString[i, 0], multiDimString[i, 1], multiDimString[i, 2]));
                        str.Write(split + split + split);   // UnterteilungsString.
                    }
                }
            }
        }
    }
}

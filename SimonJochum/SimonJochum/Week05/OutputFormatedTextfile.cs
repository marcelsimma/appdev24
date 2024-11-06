using System;
using System.IO;

namespace SimonJochum.Week05
{
    public class OutputFormatedTextfile
    {
        public static void Start()
        {
            using (StreamReader reader = new StreamReader("C:/Users/SIJO/Documents/Testaufgaben/inputnotformated.txt"))
            {
                using (StreamWriter writer = new StreamWriter(@"C:\Users\SIJO\Documents\Testaufgaben\outputformated.txt"))
                { 
                    string header = reader.ReadLine();
                    string[] headerParts = header.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    writer.WriteLine(string.Format("{0, -9} | {1, -6} | {2, -1} ",
                        headerParts[0], headerParts[1], headerParts[2]) + " |");
                    writer.WriteLine(new string('-', 30));

                    string inputRaw;
                    while ((inputRaw = reader.ReadLine()) != null)
                    {

                        string[] parts = inputRaw.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                        if (parts.Length == 3)
                        {
                            if (double.TryParse(parts[1], out double size) && int.TryParse(parts[2], out int age))
                            { 
                                writer.WriteLine(string.Format("{0, -10} | {1, -5:N2} | {2, 5} ",
                                    parts[0], size, age) + " |\n" + new string('-', 30));
                            }
                            else
                            {
                                writer.WriteLine("Fehlerhafte Daten: " + inputRaw);
                            }
                        }
                        else
                        {
                            writer.WriteLine("Fehlerhafte Zeile: " + inputRaw);
                        }
                    }
                }
            }
        }
    }
}
using System;
using System.IO;

namespace SimonJochum.Week05
{
    public class OutputToTextfile
    {
        public static void Start()
        {
            using (StreamReader reader = new StreamReader("C:/Users/SIJO/Documents/Testaufgaben/input.txt"))
            {
                using (StreamWriter writer = new StreamWriter(@"C:\Users\SIJO\Documents\Testaufgaben\output.txt"))
                {
                    string headline = reader.ReadLine();
                    string inputRaw = reader.ReadToEnd();
                    string[] input = inputRaw.Split('\n', StringSplitOptions.None);
                    int count = 0;

                    writer.WriteLine(headline + "\n");
                    foreach (string inp in input)
                    {
                        count++;
                        writer.WriteLine($"Nr.{count} {inp}");
                    }
                    writer.WriteLine($"Es sind {count} Teilnehmer auf der Liste.");
                }
            }
        }
    }
}
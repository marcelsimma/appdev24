using System;
using System.IO;

namespace JonasWehinger.Week05
{
    public class Teilnehmerliste1
    {
        public static void Streams()
        {
            
            string[] lines = File.ReadAllLines(@"C:\Digital Campus\Streams\Teilnehmer.txt");

            
            for (int i = 0; i < lines.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {lines[i]}");
            }
        }
    }
}
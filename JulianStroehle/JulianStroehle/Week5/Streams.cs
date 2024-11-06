using System;
using System.IO;
namespace JulianStroehle.Week5
{
    public class Streams
    {
        public static void Start()
        {
            Console.WriteLine("Teilnehmerliste (1), Quadrieren (2)");
            switch (Console.ReadLine())
            {
                case "1": Lines(); break;
                case "2": Squared(); break;
                default: Console.WriteLine("Fehler bei der Eingabe."); Start(); break;
            }
        }
        static void Lines()
        {
            List<string> lines = new List<string>();
            using (StreamReader str = new StreamReader("C:/Users/JUSR/Documents/Coding Campus/StreamTest/Teilnehmer.txt"))
            {
                do
                {
                    lines.Add(str.ReadLine());
                }
                while (!str.EndOfStream);
            }
            using (StreamWriter stw = new StreamWriter("C:/Users/JUSR/Documents/Coding Campus/StreamTest/Teilnehmerliste.txt"))
            {
                stw.WriteLine(lines[0] + "\n");
                for (int i = 1; i < lines.Count; i++)
                {
                    stw.WriteLine(i + ". " + lines[i]);
                }
                int temp = lines.Count - 1;
                stw.WriteLine("Es sing " + temp + " Teilnehmer auf der Liste.");
            }
        }
        static void Squared()
        {
            List<string> numbers = new List<string>();
            using (StreamReader str = new StreamReader("C:/Users/JUSR/Documents/Coding Campus/StreamTest/Zahlen.txt"))
            {
                do
                {
                    numbers.Add(str.ReadLine());
                }
                while (!str.EndOfStream);
            }
            using (StreamWriter stw = new StreamWriter("C:/Users/JUSR/Documents/Coding Campus/StreamTest/Zahlen Quadriert.txt"))
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    int temp = Convert.ToInt32(numbers[i]);
                    stw.WriteLine(string.Format("{0,10}", temp) + " zum Quadrat = " + temp * temp);
                }
            }
        }
    }
}
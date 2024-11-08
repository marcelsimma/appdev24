using System;
using System.IO;
namespace JulianStroehle.Week5
{
    public class ReadFormatWrite
    {
        private static StreamWriter stw = new StreamWriter("C:/Users/JUSR/Documents/Coding Test/outputFile.txt");
        public static void Start()
        {
            stw.AutoFlush = true;
            stw.WriteLine("Bezeichnung; Menge; Preis");
            string[] directories = Directory.GetDirectories("C:/Users/JUSR/Documents/Coding Test/test/");
            foreach (string dir in directories)
            {
                FindFile(dir);
            }

        }
        static void FindFile(string path)
        {
            string[] files = Directory.GetFiles(path);
            foreach (string file in files)
            {
                StreamReader str = new StreamReader(file);
                string[] temps = str.ReadLine().Split("; ");
                int price = -1;
                int amount = -1;
                int name = -1;
                switch (temps[0])
                {
                    case "Preis": price = 0; break;
                    case "Menge": amount = 0; break;
                    case "Bezeichnung": name = 0; break;
                }
                switch (temps[1])
                {
                    case "Preis": price = 1; break;
                    case "Menge": amount = 1; break;
                    case "Bezeichnung": name = 1; break;
                }
                switch (temps[2])
                {
                    case "Preis": price = 2; break;
                    case "Menge": amount = 2; break;
                    case "Bezeichnung": name = 2; break;
                }
                Write(str, name, amount, price);
            }
        }
        public static void Write(StreamReader str, int name, int amount, int price)
        {
            while (!str.EndOfStream)
            {
                string[] temps = str.ReadLine().Split("; ");
                stw.Write(temps[name] + "; " + temps[amount] + "; " + temps[price] + "\n");
            }
        }
    }
}
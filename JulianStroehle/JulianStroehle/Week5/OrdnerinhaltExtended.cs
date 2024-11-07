using System;
using System.IO;
namespace JulianStroehle.Week5
{
    public class OrdnerinhaltExtended
    {
        private static string path = "C:/Users/JUSR/Documents/Programme/";
        private static StreamWriter stw = new StreamWriter(path + "test2.txt");
        private static int fileCount = 0;
        private static int directoryCount = 0;
        public static void Start()
        {
            // stw.AutoFlush = true;
            int count = 0;
            stw.WriteLine("Dateien im Verzeichnis \"Programme\"");
            stw.Flush();
            Print(path, count);
            stw.WriteLine("\n" + fileCount + " Dateien\n" + directoryCount + " Ordner");
            stw.Flush();
            stw.Close();
        }
        static void Print(string directory, int count)
        {
            count += 2;
            string[] directories = Directory.GetDirectories(directory);
            string[] files = Directory.GetFiles(directory);
            for (int i = 0; i < files.Length; i++)
            {
                string[] temps = files[i].Split('/');
                if (temps[temps.Length - 1] == "\0")
                {
                    temps[temps.Length - 1] = temps[temps.Length - 2];
                }
                stw.WriteLine(new string(' ', count) + "└" + temps[temps.Length - 1] + "");
                stw.Flush();
                fileCount++;
            }
            for (int i = 0; i < directories.Length; i++)
            {
                string[] temps = directories[i].Split('/');
                if (temps[temps.Length - 1] == "\0")
                {
                    temps[temps.Length - 1] = temps[temps.Length - 2];
                }
                stw.WriteLine(new string(' ', count) + "└" + temps[temps.Length - 1]);
                stw.Flush();
                directoryCount++;
                Print(directories[i] + "/", count);
            }
        }
    }
}
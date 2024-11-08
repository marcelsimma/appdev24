using System;
using System.IO;

namespace SimonJochum.Week05
{
    public class DirectoryValueTest
    {
        public static void Start()
        {
            using StreamWriter writer = new StreamWriter(@"C:\Users\SIJO\Documents\Testaufgaben\outputdirectorypath.txt");
            string directoryPath = @"C:\Schule";
            string[] paths = Directory.GetDirectories(directoryPath);
            int countDirectorys = 0;
            int countSubDirectorys = 0;
            int countFiles = 0;

            foreach (string path in paths)
            {
                writer.WriteLine(path);
                string tempSubpath = path;
                string[] subpaths = Directory.GetDirectories(tempSubpath);
                string[] files = Directory.GetFiles(tempSubpath);
                foreach (string subpath in subpaths)
                {
                    writer.WriteLine("--" + subpath);
                    countSubDirectorys++;
                }
                foreach (string file in files)
                {
                    writer.WriteLine("---" + file);
                    countFiles++;
                }
                countDirectorys++;
            }
            writer.WriteLine($"Im Pfad {directoryPath} befinden sich {countDirectorys} Ordner, in welchem sich wiederrum {countSubDirectorys} Unterordner befinden, sowie {countFiles} Dateien befinden.");
        }

        // public static void Start2()
        // {
        //     string directoryPath = @"C:\Schule";


        //     ListFilesAndDirectories(directoryPath);
        // }

        // // Rekursive Methode zum Auflisten von Dateien und Ordnern
        // static void ListFilesAndDirectories(string path)
        // {
        //     // Alle Dateien im aktuellen Verzeichnis ausgeben
        //     string[] files = Directory.GetFiles(path);
        //     foreach (var file in files)
        //     {
        //         Console.WriteLine("Datei: " + file);
        //     }

        //     // Alle Unterordner im aktuellen Verzeichnis durchgehen
        //     string[] directories = Directory.GetDirectories(path);
        //     foreach (var directory in directories)
        //     {
        //         Console.WriteLine("Ordner: " + directory);

        //         // Rekursiv in den Unterordner gehen
        //         ListFilesAndDirectories(directory);
        //     }
        // }
    }
}
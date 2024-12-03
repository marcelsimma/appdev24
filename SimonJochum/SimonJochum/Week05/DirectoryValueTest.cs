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
    }
}
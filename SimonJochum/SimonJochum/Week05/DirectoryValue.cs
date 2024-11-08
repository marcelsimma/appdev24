using System;
using System.Formats.Asn1;
using System.IO;

namespace SimonJochum.Week05
{
    public class DirectoryValue
    {
        public static string directoryPath =  @"C:\Schule";
        public static int countDirectorys = 0;
        public static int countFiles = 0;
        
        public static void Start()
        {
            using StreamWriter writer = new StreamWriter(@"C:\Users\SIJO\Documents\Testaufgaben\outputdirectorypath2.txt");
            int count = 0;
            ListDirectories(directoryPath, count, writer);
            writer.WriteLine($"In dem Verzeichnis {directoryPath} liegen {countDirectorys} Ordner mit insgesamt {countFiles} Dateien");
        }
        public static void ListDirectories(string path, int count, StreamWriter writer)
        {
           
            string[] paths = Directory.GetDirectories(path);
            string[] files = Directory.GetFiles(path);
            foreach (string file in files)
            {
                writer.WriteLine(new string(' ', count) + '»' + file);
                countFiles++;
            }
            foreach(string path1 in paths)
            {
                writer.WriteLine(new string(' ', count) + '└' + path);
                countDirectorys++;
                count++;
                ListDirectories(path1, count, writer);
            }
        }
    }
}
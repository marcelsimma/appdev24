using System;
using System.IO;
namespace JulianStroehle.Week5
{
    public class Ordnerinhalt
    {
        public static void Start()
        {
            string path = "C:/Users/JUSR/Documents/Programme/";
            string[] files = Directory.GetFiles(path);
            string[] directories = Directory.GetDirectories(path);
            using (StreamWriter stw = new StreamWriter(path + "test.txt"))
            {
                stw.WriteLine("Dateien im Verzeichnis \"Programme\"");
                for (int i = 0; i < directories.Length; i++)
                {
                    stw.WriteLine("\t├" + directories[i].Substring(34));
                }
                for (int i = 0; i < files.Length; i++)
                {
                    if (i < files.Length - 1)
                    {
                        stw.WriteLine("\t├" + files[i].Substring(34));
                    }
                    else
                    {
                        stw.WriteLine("\t└" + files[i].Substring(34));
                    }
                }
            }
        }
    }
}
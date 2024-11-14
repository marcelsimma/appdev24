using System;
using System.IO;

namespace MagdalenaMueller.Week05
{
    public class OrdnerInhalte
    {
        static string startFilePath = "M:/Documents/Schule";
        static string currentFilepath = "M:/Documents/Schule";
        static string lastFilePath = "M:/Documents/Schule";
        public static void WriteOrdnerInhalt()
        {
            int counter = 0;
            while(startFilePath != currentFilepath || counter == 0)
            {
                int file = 0;
                int folder = 0;

                string[] files = Directory.GetFiles(currentFilepath);

                for (int i = 0; i < files.Length; i++)
                {
                    Console.WriteLine($"{Path.GetFileName(files[i])}");
                    file++;
                }

                string[] directories = Directory.GetDirectories(currentFilepath);

                for (int i = 0; i < directories.Length; i++)
                {
                    if(directories != null)
                    {
                        Console.WriteLine($"{Path.GetFileName(directories[i])}");
                        folder++; 

                        string[] subfolderFiles = Directory.GetFiles(directories[i]);
                        for (int j = 0; j < subfolderFiles.Length; j++)
                        {
                            Console.WriteLine($"--{Path.GetFileName(subfolderFiles[j])}");
                            file++; 
                        }
                        if(i <= 1)
                        {
                            lastFilePath = currentFilepath;
                        }
                        currentFilepath = currentFilepath + Path.GetFileName(directories[i]);
                    }
                    else
                    {
                        currentFilepath = lastFilePath;
                    }
                    counter++;
                }
                

                Console.WriteLine();

                Console.WriteLine($"Dateien: {file}");
                Console.WriteLine($"Ordner: {folder}");
            }
            
        }
    }
}
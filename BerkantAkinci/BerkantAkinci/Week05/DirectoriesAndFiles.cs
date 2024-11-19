using System;
using System.IO;
using System.Security.AccessControl;

namespace BerkantAkinci.Week05
{

    public class DirectoriesAndFiles
    {

        /*
        C# Dokumentation von Directory: https://learn.microsoft.com/de-de/dotnet/api/system.io.directory?view=net-8.0
        c# Dokumentation von File: https://learn.microsoft.com/de-de/dotnet/api/system.io.file?view=net-8.0
        C# Dokumentation von FileInfo (Bonus): https://learn.microsoft.com/de-de/dotnet/api/system.io.fileinfo?view=net-8.0
        */

        public static void Start()
        {

            // Arbeitsverzeichnis auf meiner Festplatte
            string directoryPath = "\\Users\\BAU26336\\OneDrive - Julius Blum GmbH\\Allgemeines\\Dokumente\\input.txt",
            fileName = "input.txt";

            /*
            // prüfen, ob eine bestimmte Datei existiert. 
            if (File.Exists(directoryPath + fileName))
            {
                Console.WriteLine("gefunden!");
            }
            else
            {
                Console.WriteLine("Datei fehlt!");
            }
            

            // Datei kopieren
            File.Copy(directoryPath + fileName, directoryPath + "neu" + "input3.txt");



            // Datei löschen
            File.Delete(directoryPath + "neuinput3.txt");


            // Neues Verzeichnis erstellen
            Directory.CreateDirectory(directoryPath + "neu2/");


            // Datei in das neue Verzeichnis verschieben und umbenennen
            File.Move(directoryPath + "input3.txt", directoryPath + "neu2/neu.txt");



            // Inhalt des Verzeichnis ausgeben
            string[] files = Directory.GetFiles(directoryPath);
            foreach (string f in files)
            {
                Console.WriteLine(f);
            }


            string[] directories = Directory.GetDirectories(directoryPath);
            foreach (string d in directories)
            {
                System.Console.WriteLine(d);
            }


            // in ein Schwesternverzeichnis navigieren
            string[] files2 = Directory.GetFiles(directoryPath + "neu/../logs/");
            foreach (string f in files2)
            {
                System.Console.WriteLine(f);
            }

*/
             directoryPath = "/Users/marcel/Documents/assets/neu/";

            // Übergeordnetes Verzeichnis
            DirectoryInfo str = Directory.GetParent(directoryPath + "../neu2/");

            System.Console.WriteLine(str.Parent);
            System.Console.WriteLine(str.Exists);
            System.Console.WriteLine(str.Extension);

            FileInfo fi = new FileInfo(directoryPath + "input.txt");

            Console.WriteLine(fi.Extension);

            

        }

    }
}
using System;
using System.Formats.Asn1;
using System.IO;

namespace SimonJochum.Week05
{
    public class DirectoryValue
{
    // Statische Variablen für den Pfad, die Anzahl der Ordner und Dateien
    public static string directoryPath = @"C:\Schule";  // Pfad zum Verzeichnis, das untersucht wird
    public static int countDirectorys = 0;               // Zähler für die Anzahl der Ordner
    public static int countFiles = 0;                    // Zähler für die Anzahl der Dateien

    // Startmethode, die den Vorgang initialisiert
    public static void Start()
    {
        // Öffnen der Ausgabedatei zum Schreiben
        using StreamWriter writer = new StreamWriter(@"C:\Users\SIJO\Documents\Testaufgaben\outputdirectorypath2.txt");

        // Zähler für die Verzeichnistiefe, initial auf 0 gesetzt
        int count = 0;

        // Aufruf der Methode, um das Verzeichnis rekursiv zu durchsuchen und das Ergebnis in die Datei zu schreiben
        ListDirectories(directoryPath, count, writer);

        // Nach der Rekursion wird die Gesamtzahl der Ordner und Dateien ausgegeben
        writer.WriteLine($"In dem Verzeichnis {directoryPath} liegen {countDirectorys} Ordner mit insgesamt {countFiles} Dateien");
    }

    // Methode, um das Verzeichnis und alle Unterverzeichnisse zu durchlaufen und in die Ausgabedatei zu schreiben
    public static void ListDirectories(string path, int count, StreamWriter writer)
    {
        // Alle Unterverzeichnisse im aktuellen Verzeichnis abrufen
        string[] paths = Directory.GetDirectories(path);

        // Alle Dateien im aktuellen Verzeichnis abrufen
        string[] files = Directory.GetFiles(path);

        // Jede Datei im aktuellen Verzeichnis in die Ausgabedatei schreiben
        foreach (string file in files)
        {
            // Schreiben des Dateipfads, eingerückt nach der Verzeichnistiefe
            writer.WriteLine(new string(' ', count) + '»' + file);

            // Erhöhen des Zählers für Dateien
            countFiles++;
        }

        // Für jedes Unterverzeichnis im aktuellen Verzeichnis:
        foreach (string path1 in paths)
        {
            // Schreiben des Unterverzeichnispfads, eingerückt nach der Verzeichnistiefe
            writer.WriteLine(new string(' ', count) + '└' + path);

            // Erhöhen des Zählers für Ordner
            countDirectorys++;

            // Rekursiver Aufruf der Methode, um auch die Unterverzeichnisse zu durchsuchen
            // Der Zähler 'count' wird erhöht, um eine tiefere Einrückung für das Unterverzeichnis zu erreichen
            count++;
            ListDirectories(path1, count, writer);
        }
    }
}

}
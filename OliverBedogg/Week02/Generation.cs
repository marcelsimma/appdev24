using System;

/*
Aufgabe: Generationen
------------------
Erstelle ein Programm zur Prüfung zu welcher Generation eine Person gehört.
Generationenjahrgänge findest du hier: https://www.adigiconsult.ch/glossar/generation-silent-baby-boomer-x-y-me-millennials-z-alpha/

+ eine Methode für die Zuordnung der Generation, durch Eingabe des Alters

Überprüfe die Methode mit je einer Person pro Generation.
Und gib jede Person aus.

Ausgabe:
Anna 10: Generation Alpha
Peter 20: Generation Z
...
*/

namespace OliverBedogg.Week02
{

    public class Generation
    {
        public static void Start()
        {
            // Funktionsaufrufe und Ausgabe
            Console.WriteLine("Anna 10: " + getGenerationByAge(10));
            Console.WriteLine("Peter 20: " + getGenerationByAge(20));
            Console.WriteLine("Silvia 30: " + getGenerationByAge(30));
            Console.WriteLine("Ines 50: Generation " + getGenerationByAge2(50));
        }

        // Methode 1
        static string getGenerationByAge(int age)
        {
            string generation = "";
            int year = 2024 - age;

            Console.WriteLine("// Geburtsjahr: " + year);

            if (year >= 2011)
            {
                generation = "Alpha";
            }
            else if (year <= 2010 && year >= 1997)
            {
                generation = "Z";
            }
            else if (year <= 1996 && year >= 1981)
            {
                generation = "Y";
            } // ...

            return "Generation " + generation;
        }

        // short
        static string getGenerationByAge2(int age)
        {
            int year = 2024 - age;

            if (year >= 2011)
                return "Alpha";
            else if (year <= 2010 && year >= 1997)
                return "Z";
            else if (year <= 1996 && year >= 1981)
                return "Y";
            else if (year <= 1980 && year >= 1965)
                return "X";
            // ...
            else
                return "vor 1928";
        }
    }
}
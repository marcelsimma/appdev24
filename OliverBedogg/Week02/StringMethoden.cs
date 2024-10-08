using System;

/*
Aufgabe: Führerschein
------------------
Erstelle ein Programm zur Prüfung ob Personen an Hand ihres alters Berechtigt sind Moped und/oder Auto zu fahren.

+ eine Methode für die Überprüfung für das Moped
+ eine Methode für die Überprüfung für das Auto

Rufe die Methoden mit 4-5 Personen auf.
Und gib für jede Person aus, ob sie für Moped, Auto einzeln und beide Fahrzeuge berechtigt ist.

Ausgabe:
Michael 16: Moped Ja, Auto Nein, für beide Fahrzeuge: Nein
Peter 20: Moped Ja, Auto Ja, für beide Fahrzeuge: Ja
...
*/

namespace OliverBedogg.Week02
{

    public class StringMethoden
    {
        public static void Start()
        {
            string lorem = "Lorem";
            Console.WriteLine("Textlänge: " + lorem.Length);
            Console.WriteLine("in Großbuchstaben: " + lorem.ToUpper());
            Console.WriteLine("in Kleinbuchstaben: " + lorem.ToLower());
            Console.WriteLine("--------------------");

            // Concatenation ... Stringverkettung -----------
            string ipsum = "Lorem " + "ipsum";
            Console.WriteLine("string: " + ipsum);
            //ipsum = 10 + 20; // funktioniert nicht
            ipsum = "10" + 20;
            Console.WriteLine("string: " + ipsum);

            string loremIpsum = string.Concat(ipsum, " dolor", " sit", " amet");
            Console.WriteLine("string: " + loremIpsum);
            loremIpsum = string.Concat(ipsum, 10, 20);
            Console.WriteLine("string: " + loremIpsum);
            Console.WriteLine("--------------------");

            // Interpolation
            lorem = "Lorem";
            ipsum = "ipsum";
            loremIpsum = $"{lorem} {ipsum}";
            Console.WriteLine("string: " + loremIpsum);
            Console.WriteLine("--------------------");

            // Characters
            string quote = "The more you learn. The more you earn.";
            for (int i = 0; i < quote.Length; i++)
            {
                Console.WriteLine($"Character {i}: " + quote[i]);
            }
            Console.WriteLine("--------------------");

            // Position
            Console.WriteLine("index von \"learn\" " + quote.IndexOf("learn"));
            // special character: \"
            Console.WriteLine("index von \"earn\" " + quote.IndexOf("earn"));
            Console.WriteLine("index von \"earn\" " + quote.IndexOf("life"));
            Console.WriteLine("--------------------");

            // Substring
            Console.WriteLine("Substring ab Index: " + quote.Substring(20));
            Console.WriteLine("--------------------");
        }
    }
}
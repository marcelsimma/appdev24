using System;

namespace OliverBedogg.Week02
{

    public class StringsVergleich
    {
        public static void Start()
        {
            string s1 = "hello!";

            string s2 = "HeLLo!";
            // case-sensitive
            Console.WriteLine(s1 == s2.ToLower());  // output: True
            Console.WriteLine(s1 == "hello!");  // output: True
            Console.WriteLine("--------------------");

            string s3 = "Hello!";
            Console.WriteLine(s1 == s3);  // output: False
            Console.WriteLine("--------------------");


            // lexikographischer Vergleich --------------------------
            // zur Ermittlung der Sortierreihenfolge
            // CompareTo
            s1 = "Apfel";
            s2 = "Birne";
            s3 = "apfel";

            // Apfel beginnend mit A kommt vor Birne beginnend mit B
            Console.WriteLine(s1.CompareTo(s2));  // output: -1
            Console.WriteLine(s2.CompareTo(s1));  // output: 1

            // Kleinbuchstaben vor Großbuchstaben
            Console.WriteLine(s1.CompareTo(s3));  // output: 1
            Console.WriteLine(s1.CompareTo("Apfel"));  // output: 0
            Console.WriteLine("--------------------");

            // Compare mit Startindex für den Vergleich
            // String1 mit Anfangsposition1 wird verglichen mit
            // String2 mit Anfangsposition2
            // TODO: Teste die Anwendung der Methode
            // https://learn.microsoft.com/de-de/dotnet/api/system.string.compare?view=net-8.0
        }
    }
}
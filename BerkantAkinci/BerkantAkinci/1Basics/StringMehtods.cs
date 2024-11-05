using System;

namespace BerkantAkinci.Basics
{

    class StringMethoden
    {

        public static void String()
        {
            string example = "Hallo, hallo liebes Publikum!";

            int stringLength = example.Length;  // gibt die Länge vom String aus = 29
            Console.WriteLine(stringLength);

            string substring = example.Substring(3, 5); // 3 gibt den Index an wo es anfängt zu zählen und 5 für wie lange
            Console.WriteLine(substring);               // das heißt es beginnt ab der Indexstelle 3 die nächsten 5 Zeichen auszugeben

            int index = example.IndexOf("lo"); // gibt an an welcher Stelle das Eingegebene beginnt
            Console.WriteLine(index);

            bool enthalten = example.Contains("Leib"); // kontrolliert ob das eingegeben erhalten ist in dem Text
            Console.WriteLine(enthalten);

            example.StartsWith("Halo"); 

            example.EndsWith("kum!");

            string[] splitted = example.Split("l"); // das eingegebne wird herausgelöscht

            foreach (string elem in splitted)
            {
                Console.Write(elem);
            }

            Console.WriteLine();

            string zusammengebaut = string.Join("&&", splitted); // hier kann man das herausgelöschte durch was anderem ersetzen

            Console.WriteLine(zusammengebaut);


            double kommazahl = 12.345678;

            double formatiert = Math.Round(kommazahl, 2); //rundet auf 2 Nachkommastellen

            string result = string.Format("Distanz: {0, 20:F2}", formatiert); //formatierung -> die besetzten Zeilen und die Nachkommastelle(Kommastelle untereinander gesetzt)

            Console.WriteLine(result);


            string input = "Hallo, lieber !";
            string person = "Nico";

            string concated = input.Insert(14, person); // setzte ich ein Wort in den Satz hinein
            Console.WriteLine(concated);

            string salutation = concated.Remove(7, 7); //entferne ich bestimmte Zeilen
            Console.WriteLine(salutation);

            string textToTrim = "     jkldöasdölkf      "; // die unnötoigen Abstände werden gelöscht

            Console.WriteLine(textToTrim.Trim());
        }
    }
}
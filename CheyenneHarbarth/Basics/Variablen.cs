//Alles zu Integern

using System;

namespace CheyenneHarbarth.Basics
{                 //namespace zum strukturieren unseres Codes für Dateien, quasi ein Regal

    class Variablen
    {                               //Klasse ist wie ein Paket im Regal, die Methoden etc sind er Inhalt, mit Zeug außerhalb der Kiste kann niemand was anfangen, ist nur ein Saustall

        public static void Integer()
        {              //public bedeutet, ich kann in einer anderen Datei auf diese Methode zugreifen

            int Zahl;                               //Ein Integer ist ein Ganzzahl, hier wird der Integer definiert
            Zahl = 1;                               //hier wird er Initialisiert

            int Nummer = 2;

            int Ergebnis;
            //integer als Synonym, die namen anstatt der zahlen
            Ergebnis = 1 + 2;
            Ergebnis = Zahl + Nummer;               //mit integern kann gerechnet werden, egal ob + - * oder /
            //du kannst an jeder Position im Code die einen Wert fordert einen Variablen-Namen einsetzen, so kannst du einen Code komplett ohne Zahlen schreiben

        }

        public static void Character()
        {

            char Zeichen;
            Zeichen = '*';                          //char sind character, also Zeichen, Buchstaben, auch Zahlen, allerdings kann man mit einem char nicht rechen
            //ein Symbol wir immer mit '..' angegeben
        }

        public static void Operatoren()             //Operatoren sind vordefinierte Zeichen, die uns das coden erleichtern
        {

        }

        public static void String()
        {
            string example = "Hallo, liebes Publikum!";
            
            //Array erstellen aus String
            char[] exampleArray = example.ToCharArray();

            //Länge eines Strings
            int stringLength = example.Length;
            Console.WriteLine($"Länge des Strings: {stringLength}");

            //Klein oder Großschreibung
            Console.WriteLine(example.ToUpper());
            Console.WriteLine(example.ToLower());

            //Substring ausgeben
            string substring = example.Substring(3,5);
            Console.WriteLine(substring);

            //Index finden
            int index = example.IndexOf("lo");
            Console.WriteLine(index);

            //Contains, um Inhalte zu finden
            bool enthalten = example.Contains("Leib");
            Console.WriteLine(enthalten);               //gibt uns nur zurück ob es enthalten ist, also true oder false, keinen Indexwert

            //Start und Ende
            example.StartsWith("Halo");
            example.EndsWith("kum!");

            //Split, auseinandertrennen
            string[] splitted = example.Split("l");
            foreach(string elem in splitted) {
                Console.Write(elem);
            }
            Console.WriteLine();

            //Join, wieder zusammenstecken
            string zusammengebaut = string.Join("&&", splitted);
            Console.WriteLine(zusammengebaut);

            //Format, hier kann ich formatieren
            double kommazahl = 12.5749364;
            string result = string.Format("Distanz: {0, 20:F2}", kommazahl);
            Console.WriteLine(result);

            //Einfügen von Strings in anderen Strings
            string input = "Hallo liebe !";
            string person = "Cheyenne";

            string concated = input.Insert(14, person);
            Console.WriteLine(concated);

            //Entfernen oder rausnehmen
            string salutation = input.Remove(7, 6);

            //Trim, also kürzen
            string TexttoTrim = "     Hallo!";
            Console.WriteLine(TexttoTrim.Trim());
        }
    }
}
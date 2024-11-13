using System;

namespace MarcelSimma.Week06
{

    /*

    Klasse: Fertigungsstraße
    Konstruktor: Fertigungsauftrag mit allen Spezifikationen
    Objekt: Das fertie Objekt der Wirklichkeit. Dieses wird aus der Klasse

    */

    public class Auto
    {

        /*

        offizielle Namenskonvention von Microsoft für C#: https://learn.microsoft.com/de-de/dotnet/csharp/fundamentals/coding-style/identifier-names
          - Verwenden Sie PascalCase für Klassen- und Methodennamen.
          - Verwenden Sie camelCase für Methodenparameter und lokale Variablen.
          - Private Instanzfelder beginnen mit einem Unterstrich (_) und der restliche Text wird in camelCase geschrieben.

        */

        // Instanzattribute: Attribute, die dem Objekt zugeordnet werden
       
       
        // privates Feld, in dem der Wert für den Kilometerstand gespeichert wird. 
        private int _kilometerstand;

        // öffentliches Attribut, über das mit Getter und Setter interagiert werden kann. 
        public int Kilometerstand
        {
            // in Getter und Setter kann ich zusätzliche Logik für Validierung einbauen.
            get { return _kilometerstand; }
            set
            {
                if (_kilometerstand <= value)
                {
                    _kilometerstand = value;
                }
                else
                {
                    System.Console.WriteLine("Kilometerstand kann nicht zurückgesetzt werden.");
                }
            }
        }
       
        public string Modell;

        // dieses Attribut kann nur gelesen werden. Nachdem es im Konstruktor definiert wurde, kann es nicht mehr bearbeitet werden. 
        public int Baujahr
        {
            get;
        }
        public string Seriennummer;

        // static sorgt dafür, dass das Attribut der Klasse und nicht dem Objekt zugeordnet wird. 
        public static int AnzahlDerFahrzeuge = 0;

        public Auto(string modell, int baujahr, string seriennummer)
        {

            Modell = modell;
            Baujahr = baujahr;
            Seriennummer = seriennummer;
            _kilometerstand = 0;

            AnzahlDerFahrzeuge++;

        }

        public void Drive()
        {
            System.Console.WriteLine("Ich fahre auto!");
        }

        public void Brake()
        {
            System.Console.WriteLine("Ich bremse!");
        }

        public void Steer()
        {
            System.Console.WriteLine("Ich weiche dem Baum aus!");
        }

        public override string ToString()
        {
            return "Das ist unser Auto.";
        }



    }



}
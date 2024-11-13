using System;

namespace ManuelHartmann.Week05
{
    // Klasse
    public class Camera
    {
        // Attribute
        int _Brennweite;  // Min./Max.
        string _Model;
        string _Hersteller;
        int _Megapixel;

        // mit 'get' gebe ich nur Leserechte auf das Model.
        public string Model
        {
            get => "\"" + _Model + "\"";
        }

        public string Hersteller
        {
            get => "\"" + _Hersteller + "\"";
        }

        // Public lesen und schreiben fuer die Brennweite
        public int Brennweite
        {
            get => _Brennweite; // Ueber 'get' wird eine Leseberechtigung/Moeglichkeit fuer andere Klassen etc. geschaffen.
            set => _Brennweite = value; // Ueber 'set' wird eine Schreibeberechtigung/Moeglichkeit fuer andere Klasse etc. geschaffen.
        }

        public int Megapixel
        {
            get => _Megapixel; // Ueber 'get' wird eine Leseberechtigung/Moeglichkeit fuer andere Klassen etc. geschaffen.
            set => _Megapixel = value; // Ueber 'set' wird eine Schreibeberechtigung/Moeglichkeit fuer andere Klasse etc. geschaffen.
        }

        // Konstruktor
        public Camera(int brennweite, string model, string hersteller, int megapixel)
        {
            _Brennweite = brennweite;
            _Model = model;
            _Hersteller = hersteller;
            _Megapixel = megapixel;
        }

        public Camera(int brennweite) 
        {
            _Brennweite = brennweite;
        }

        // Methode
        // public void hasABirthday()
        // {
        //     _Age++;
        // }

        /* besprochene Beispiel-Methoden für ein Auto:
        public void fahren() {
            _Kilometerstand++;
        }

        public void fahreDistanz(int kilometer) {
            _Kilometerstand += kilometer;
        }

        public void fahreDistanzArbeitsplatz() {
            _Kilometerstand += 40;
        }
        */

        // public override string ToString()
        // {
        //     return string.Format("Person: {0}, age: {1}", _Name, _Age);
        // }
    }
}
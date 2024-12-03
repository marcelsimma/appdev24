using System;

namespace ManuelHartmann.Week05
{
    // Klasse
    public class Person
    {
        // Attribute
        public string _Name;
        public int _Age;
        int _Height;
        int _Weight;

        // getter mit erweiterter Rückgabe des Attributwerts
        public string Name
        {
            get => "\"" + _Name + "\"";
        }

        // getter und setter für die Größe
        public int Height
        {
            get => _Height; // Ueber 'get' wird eine Leseberechtigung/Moeglichkeit fuer andere Klassen etc. geschaffen.
            set => _Height = value; // Ueber 'set' wird eine Schreibeberechtigung/Moeglichkeit fuer andere Klasse etc. geschaffen.
        }

        // Konstruktor
        public Person(string name, int age, int height, int weigth)
        {
            _Name = name;
            _Age = age;
            _Height = height;
            _Weight = weigth;
        }

        // Methode
        public void hasABirthday()
        {
            _Age++;
        }

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

        public override string ToString()
        {
            return string.Format("Person: {0}, age: {1}", _Name, _Age);
        }
    }
}
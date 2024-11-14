using System;

namespace OliverBedogg.Week05
{
    // Klasse
    public class Person
    {
        // Attribute
        public string _Name;
        public int _Age;
        int _Height; //m
        int _Weight;

        // getter mit erweiterter Rückgabe des Attributwerts
        public string Name
        {
            get => "\"" + _Name + "\"";
        }

        // getter und setter für die Größe
        public int Height
        {
            get => _Height;
            set => _Height = value;
        }

        // Konstruktor
        public Person(string name, int age, int height, int weigth)
        {
            _Name = name;
            _Age = age;
            _Height = height;
            _Weight = weigth;
        }

        public int getHeight() {
            return _Height * 100;
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
using System;

namespace CheyenneHarbarth.Week05.OOP
{
    class ErsteSchritteOOP
    {
        public static void Start()
        {
            //hier erstellen wir dann ein Objekt der Klasse Person, mit diesem Objekt können wir dann weiterarbeiten
            Person pers = new Person();
            //wir geben alle wichtigen Infos dem Bauplan, und erstellt damit ein neues Objekt
            pers.Name = "Cheyenne";
            pers.Alter = 24;

            //Hier rufen wir dann eine Methode mit dem erstellten Objekt auf
            Console.WriteLine(pers.toString());
        }
    }
    class Auto
    {
        //Attribute
        string Marke;
        int Preis;
        string Farbe;
        int PS;

        public string toString()
        {
            return string.Format($"Auto: {Marke}, Farbe: {Farbe}, PS: {PS}, Preis: {Preis}");
        }

    }
    class Person
    {
        //Attribute
        public string Name;
        public int Alter;
        public int Kontostand;

        //Methoden, also Dinge die wir mit dem Objekt Person tun können, z.B. den Namen und Alter ausgeben
        public string toString()
        {
            return string.Format($"Person: {Name}, {Alter} Jahre, Kontostand: {Kontostand}");
        }
    }
    class Bank
    {
        string Name;
        double Zinsen;
        int Betrag;
        double Darlehen;

        public string toString()
        {
            return string.Format($"Bank: {Name}, Betrag: {Betrag}, Zinsen: {Zinsen}, Darlehen: {Darlehen}");
        }
    }
}
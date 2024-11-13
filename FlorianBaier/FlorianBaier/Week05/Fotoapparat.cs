using System;

namespace FlorianBaier.Week05
{
    // Klasse für Objektiv
    class Objektiv
    {
        public int MinBrennweite { get; set; }
        public int MaxBrennweite { get; set; }

        // Konstruktor
        public Objektiv(int minBrennweite, int maxBrennweite)
        {
            MinBrennweite = minBrennweite;
            MaxBrennweite = maxBrennweite;
        }

        public override string ToString()
        {
            return $"Brennweite: {MinBrennweite}mm - {MaxBrennweite}mm";
        }
    }

    // Klasse für Speicherkarte
    class Speicherkarte
    {
        public int Kapazitaet { get; set; }
        public string Typ { get; set; }

        // Konstruktor
        public Speicherkarte(int kapazitaet, string typ)
        {
            Kapazitaet = kapazitaet;
            Typ = typ;
        }

        public override string ToString()
        {
            return $"{Kapazitaet} GB {Typ}";
        }
    }

    // Klasse für Fotoapparat
    class Fotoapparat
    {
        // Attribute
        private string model;
        private string hersteller;
        private double megapixel;
        private Objektiv objektiv;
        private Speicherkarte speicherkarte;

        // Konstruktor
        public Fotoapparat(string model, string hersteller, double megapixel)
        {
            this.model = model;
            this.hersteller = hersteller;
            this.megapixel = megapixel;
        }

        // Eigenschaften
        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public string Hersteller
        {
            get { return hersteller; }
            set { hersteller = value; }
        }

        public double Megapixel
        {
            get { return megapixel; }
            set { megapixel = value; }
        }

        // Objektiv setzen und wechseln
        public void SetzeObjektiv(Objektiv neuesObjektiv)
        {
            objektiv = neuesObjektiv;
        }

        public void WechselObjektiv(Objektiv neuesObjektiv)
        {
            objektiv = neuesObjektiv;
            Console.WriteLine($"Objektiv gewechselt auf: {objektiv}");
        }

        // Speicherkarte setzen und wechseln
        public void SetzeSpeicherkarte(Speicherkarte neueSpeicherkarte)
        {
            speicherkarte = neueSpeicherkarte;
        }

        public void WechselSpeicherkarte(Speicherkarte neueSpeicherkarte)
        {
            speicherkarte = neueSpeicherkarte;
            Console.WriteLine($"Speicherkarte gewechselt: {speicherkarte}");
        }

        // Foto aufnehmen
        public void TakePhoto()
        {
            Console.WriteLine($"{model} hat ein Foto geschossen mit {objektiv} und einer Speicherkarte {speicherkarte}!");
        }

        // Datenblatt der Kamera
        public override string ToString()
        {
            string objektivInfo = objektiv != null ? objektiv.ToString() : "Kein Objektiv";
            string speicherkarteInfo = speicherkarte != null ? speicherkarte.ToString() : "Keine Speicherkarte";
            return $"Fotoapparat {model} ({hersteller})\n" +
                   $"Megapixel: {megapixel} MP\n" +
                   $"Objektiv: {objektivInfo}\n" +
                   $"Speicherkarte: {speicherkarteInfo}";
        }

        public static void Print()
        {
            // Erstelle Instanzen von Objektiv und Speicherkarte
            Objektiv objektiv1 = new Objektiv(24, 70);
            Objektiv objektiv2 = new Objektiv(70, 200);
            Speicherkarte speicherkarte1 = new Speicherkarte(64, "SDXC");
            Speicherkarte speicherkarte2 = new Speicherkarte(128, "microSD");

            // Erstelle eine Instanz der Fotoapparat-Klasse
            Fotoapparat kamera1 = new Fotoapparat("Alpha 7R IV", "Sony", 61.0);

            // Setze Objektiv und Speicherkarte
            kamera1.SetzeObjektiv(objektiv1);
            kamera1.SetzeSpeicherkarte(speicherkarte1);

            // Ausgabe der Kamera-Daten
            Console.WriteLine("Kamera 1 - Datenblatt:");
            Console.WriteLine(kamera1.ToString());

            // Foto schießen
            Console.WriteLine("\nSchieße ein Foto mit Kamera 1:");
            kamera1.TakePhoto();

            // Objektiv und Speicherkarte wechseln
            Console.WriteLine("\nWechsel Objektiv und Speicherkarte...");
            kamera1.WechselObjektiv(objektiv2);
            kamera1.WechselSpeicherkarte(speicherkarte2);

            // Ausgabe nach dem Wechsel
            Console.WriteLine("\nKamera 1 - Nach Wechsel:");
            Console.WriteLine(kamera1.ToString());

            // Foto schießen nach dem Wechsel
            Console.WriteLine("\nSchieße ein Foto mit der neuen Konfiguration:");
            kamera1.TakePhoto();
        }
    }
}
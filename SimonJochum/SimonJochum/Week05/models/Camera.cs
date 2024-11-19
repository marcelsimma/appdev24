using System;

namespace SimonJochum.Week05
{
    public class Camera
    {
        // Felder für die Kameraeigenschaften
        string _Brand; // Markenname der Kamera
        string _Model; // Modellname der Kamera
        int _BrennweiteMin; // Minimale Brennweite der Kamera
        int _BrennweiteMax; // Maximale Brennweite der Kamera
        public double _Megapixel; // Auflösung der Kamera in Megapixeln
        Objektiv _Objektiv; // Objektiv-Objekt, das zu dieser Kamera gehört
        Speicherkarte _Karte; // Speicherkarte-Objekt, das zu dieser Kamera gehört

        // Konstruktor, der Kamera mit Marke, Modell und Megapixel initialisiert und ein Standard-Objektiv und Speicherkarte erstellt
        public Camera(string brand, string model, double megapixel)
        {
            _Brand = brand;
            _Model = model;
            _Megapixel = megapixel;

            _Objektiv = new Objektiv("Obj-1234", 50); // Standard-Objektiv wird zugewiesen
            _Karte = new Speicherkarte("Samsung", 32, 4); // Standard-Speicherkarte wird zugewiesen
        }

        // Überladener Konstruktor, der zusätzlich minimale und maximale Brennweiten aufnimmt
        public Camera(string brand, string model, int brennweiteMin, int brennweiteMax, double megapixel)
        {
            _Brand = brand;
            _Model = model;
            _BrennweiteMin = brennweiteMin;
            _BrennweiteMax = brennweiteMax;
            _Megapixel = megapixel;
        }

        // Eigenschaften zum Setzen und Abrufen der Marken- und Modelleigenschaften
        public string Brand
        {
            get => _Brand;
            set => _Brand = value;
        }

        public string Model
        {
            get => _Model;
            set => _Model = value;
        }

        public double Megapixel
        {
            get => _Megapixel;
            set => _Megapixel = value;
        }

        public int BrennweiteMin
        {
            get => _BrennweiteMin;
            set => _BrennweiteMin = value;
        }

        public int BrennweiteMax
        {
            get => _BrennweiteMax;
            set => _BrennweiteMax = value;
        }

        // Eigenschaften für das Objektiv und die Speicherkarte, die der Kamera zugeordnet sind
        public Objektiv Objektiv
        {
            get => _Objektiv;
            set => _Objektiv = value;
        }

        public Speicherkarte Karte
        {
            get => _Karte;
            set => _Karte = value;
        }

        // Eigenschaft zur Übergabe der Megapixel von der Kamera an andere Klassen
        public double UebergabeMegapixel { get; set; }

        // Konstruktor für die Übergabe der Megapixel
        public Camera(double _Megapixel)
        {
            UebergabeMegapixel = _Megapixel;
        }

        // Methode gibt einen Text aus, der angibt, von welcher Kamera das Foto aufgenommen wurde
        public string CameraWhoTookPhoto()
        {
            return "Dieses Foto wurde von der Kamera \"" + _Brand + " " + _Model + "\" aufgenommen.";
        }

        // Methode zum Fotografieren; je nach Brennweite wird ein anderes ASCII-Bild ausgegeben
        public string takePhoto()
        {
            if (Objektiv.Brennweite < 60) // Wenn die Brennweite kleiner als 60 ist
            {
                // Speicherplatzverbrauch wird hinzugefügt, basierend auf der Megapixelanzahl
                Karte.SpeicherVolumenVerbraucht += Convert.ToInt32(Megapixel * 0.3);
                return @"
             ☻    
            /|\ 
            / \ 
            ";
            }
            else // Wenn die Brennweite größer oder gleich 60 ist
            {
                Karte.SpeicherVolumenVerbraucht += Convert.ToInt32(Megapixel * 0.3);
                return @"
             _
            (_)
            /|\
           / | \
          /  |  \
            / \
           /   \
           ";
            }
        }

        // Methode für die Aufnahme eines größeren Fotos
        public string takeBiggerPhoto()
        {
            return @"
             _
            (_)
            /|\
           / | \
          /  |  \
            / \
           /   \
           ";
        }

        // Gibt eine beschreibende Zeichenkette über die Kamera zurück
        public override string ToString()
        {
            return string.Format("Das Modell " + _Model + " kommt von " + _Brand + " und hat " + _Megapixel + "\'MP\'");
        }
    }

    public class Objektiv
    {
        // Konstruktor zur Initialisierung des Objektivs
        public Objektiv(string name, int brennweite)
        {
            _Name = name;
            _Brennweite = brennweite;
        }

        // Felder für Objektiveigenschaften
        string _Name; // Name des Objektivs
        int _Brennweite; // Brennweite des Objektivs

        // Eigenschaften für die Brennweite und den Namen des Objektivs
        public int Brennweite
        {
            get => _Brennweite;
            set => _Brennweite = value;
        }

        public string Name
        {
            get => _Name;
            set => _Name = value;
        }

        // Gibt eine beschreibende Zeichenkette über das Objektiv zurück
        public override string ToString()
        {
            return string.Format(", mit dem Objektiv {0} welches eine Brennweite von {1}mm hat", _Name, _Brennweite);
        }
    }

    public class Speicherkarte
    {
        // Felder für die Speicherkarteneigenschaften
        string _Name; // Name der Speicherkarte
        int _SpeicherVolumenInsgesamt; // Gesamtes Speichervermögen in MB
        int _SpeicherVolumenVerbraucht; // Genutzter Speicher in MB
        double UebergabeMegapixel; // Übergabewert für Megapixel (wird nicht direkt verwendet)

        // Methode, um die Megapixel-Informationen aus der Kamera zu übernehmen
        public void UebergabeAusCamera(double _Megapixel)
        {
            UebergabeMegapixel = _Megapixel;
        }

        // Eigenschaften für den Namen, das Gesamtspeicher- und Verbrauchsvolumen der Speicherkarte
        public string Name
        {
            get => _Name;
            set => _Name = value;
        }

        public int SpeicherVolumenInsgesamt
        {
            get => _SpeicherVolumenInsgesamt;
            set => _SpeicherVolumenInsgesamt = value;
        }

        public int SpeicherVolumenVerbraucht
        {
            get => _SpeicherVolumenVerbraucht;
            set => _SpeicherVolumenVerbraucht = value;
        }

        // Konstruktor zur Initialisierung der Speicherkarte mit Name, Gesamtspeicher und Verbrauch
        public Speicherkarte(string name, int speicherVolumenInsgesamt, int speicherVolumenVerbraucht)
        {
            _Name = name;
            _SpeicherVolumenInsgesamt = speicherVolumenInsgesamt * 1000; // in MB konvertiert
            _SpeicherVolumenVerbraucht = speicherVolumenVerbraucht * 1000; // in MB konvertiert
        }

        // Berechnet die Anzahl der Fotos, die auf der Speicherkarte gespeichert werden können
        public double BilderAufSpeicherkarte()
        {
            double anzahlBilder = SpeicherVolumenVerbraucht / (UebergabeMegapixel * 0.3);
            Console.WriteLine("Ein Bild hat " + UebergabeMegapixel * 0.3 + "MB.");
            return anzahlBilder;
        }

        // Gibt eine beschreibende Zeichenkette über die Speicherkarte zurück
        public override string ToString()
        {
            return string.Format(" und die Speicherkarte von {0} hat eine Größe von {1}GB von denen {2}GB belegt sind.", _Name, _SpeicherVolumenInsgesamt, _SpeicherVolumenVerbraucht);
        }
    }
}
using System;

namespace CheyenneHarbarth.Week05.OOP.Fotoapparat
{
    /* class FotoapparatOOP
    {
        public static void Start()
        {
            Fotoapparat fotoapparat1 = new Fotoapparat();

            fotoapparat1._Hersteller = "Cannon";
            fotoapparat1._Modell = "EOS R10";
            fotoapparat1._Megapixel = 24.2;
            fotoapparat1._BrennweiteMin = 100;
            fotoapparat1._BrennweiteMax = 400;

            Console.WriteLine(fotoapparat1.toString());
            fotoapparat1.takePhoto();
        }
    }
    
    class Fotoapparat
    {
        int BrennweiteMin;
        int BrennweiteMax;
        string Modell;
        string Hersteller;
        double Megapixel;

        public string _Hersteller               //Unterstrich + Name ist die "korrekte" Schreibweise
        {
            get => Hersteller;                  //get holt sich den Wert
            set => Hersteller = value;          //mit set kann ich denn Wert durch aufrufen der Variable ändern/schreiben, hier könnte man auch prüfen, ob der Wert auch in dem Format geschrieben wird, dass benötigt wird, z.B. keinen string in einem int speichern
        }

        public string _Modell
        {
            get => Modell;
            set => Modell = value;
        }

        public double _Megapixel
        {
            get => Megapixel;
            set => Megapixel = value;
        }

        public int _BrennweiteMin
        {
            get => BrennweiteMin;
            set => BrennweiteMin = value;
        }

        public int _BrennweiteMax
        {
            get => BrennweiteMax;
            set => BrennweiteMax = value;
        }



        public void TakePhoto()    //Methoden schreibt man groß, ist einheitlich
        {
            Random random = new Random();
            int face = random.Next(1, 3);
            Console.WriteLine("\n3, 2, 1, cheeeeese \n*klick*\n   " + (char)face + "\n  \\|/\n   |\n  / \\");
        }

        public string toString()
        {
            return string.Format($"Hersteller: {_Hersteller}, Modell: {Modell}\nMegapixel: {Megapixel:F1}\nBrennweite Min. & Max.: {BrennweiteMin} mm - {BrennweiteMax} mm");
        }
    }
 */

    //Erarbeitung mit Marcel
    public class Fotoapparat
    {
        //In dieser Varibale wird der Wert gespeichert
        private string _model;         //durch private ist es nur in dieser Klasse & desen Objekte verfügbar

        //Diese Variable nutze ich, um mit der Außenwelt zu kommunizieren, mit get und set machst du die Struktur des Programms sicherer, da niemand die "Ur-Variablen" ändern kann, oder löschen, etc
        public string Model
        {
            get { return _model; }
            set
            {   //hier könntest du auch noch prüfen, ob gewisse Kriterien erfüllt sind um einen neuen Wert zu speichern
                _model = value;         //value ist wie eine Hilfsvariable/Platzhalter
            }
        }

        private double _megapixel;
        public double Megapixel
        {
            get { return _megapixel; }
            set
            {
                if (value > 0)
                {
                    _megapixel = value;
                }
                else
                {
                    Console.WriteLine("Megapixel kann nicht negativ sein!");
                }
            }
        }

        //Alternative Schreibweisen
        private double _focalwidthmin;
        public double FocalWidthMin
        {
            get => _focalwidthmin;              //=> ist ein Lambdaausdruck, diese sollen uns helfen, code effizienter zu gestalten, einfacher lesbar zu machen
            set => _focalwidthmin = value;      //es ersetzt diese {} Klammer und den Begriff return
        }

        private double _focalwidthmax;
        public double FocalWidthMax
        {
            get => _focalwidthmax;
            set => _focalwidthmax = (value > 0 && value > _focalwidthmin) ? value : _focalwidthmax;         //? löst hier die if-Bedingung, so kann ich es kürzer schreiben, Schreibweise: Variable = Bedingung, wird genau gleich geschrieben wie bei if-Schleifen, bei mehreren Bedingungen mit () und klassischen Operatoren && || ... ? Ergebnis : else-Ergebnis
            //Verschachtelung :set => _focalwidthmax = value > 0 ? value > FocalWidthMin ? value : _focalwidthmax : _focalwidthmax;     oberes ist einfacher zu schreiben 
            //                                         Bedingung 1 ?     Bedingung 2 ?     wahr : falsch : falsch    nur wenn beide richtig sind trifft wahr zu, wenn 1 richtig und 2 falsch ist kommt falsch und wenn 1 und 2 flasch sind kommt falsch
        }

        public double MemoryLeft { get; private set; }

        public int AmountOfPictures;
        public string Manufacterer;
        //hier wird im Hintergrund alles "automatisch" erledigt in Bezug auf get, set

        //Konstruktor, ist wie eine Methode, alles was ich angebe muss später einen Wert erhalten wenn ich das Objekt erstelle, ansonsten kann es nicht erstellt werden
        public Fotoapparat(string model, double megapixel, double focalWidthMax, double focalWidthMin, string manufacterer, double memoryLeft)      //weil der Übergabeparameter an sich nichts mit der Klasse sondern nur mit dem Konstruktor, nachdem das Objekt erstellt wurde, werden die Variablen des Konstruktors gelöscht
        {
            _model = model;
            _megapixel = megapixel;
            _focalwidthmax = focalWidthMax;
            _focalwidthmin = focalWidthMin;
            Manufacterer = manufacterer;
            MemoryLeft = memoryLeft;
            AmountOfPictures = 0;
        }

        public void TakePhoto()
        {
            //restlichen Speicherplatz
            double memoryUsage = CalculateMemoryForPictures();
            if (MemoryLeft - memoryUsage > 0)
            {
                MemoryLeft -= memoryUsage;
                int face = 2;
                Console.WriteLine("\n3, 2, 1, cheeeeese \n*klick*\n   " + (char)face + "\n  \\|/\n   |\n  / \\");
                AmountOfPictures++;
            }
            else
            {
                Console.WriteLine("Speicherplatz ist voll!");
            }
        }

        public double CalculateMemoryForPictures()
        {   //Berechnung des Speicherplatzverbrauchs pro Bild
            return Megapixel * 0.3;
        }

        public override string ToString()
        {
            return String.Format(
            @"
            Datenblatt:

            Hersteller {0}
            Modell: {1}
            Megapixel: {2}
            Minimale Brennweite {3}
            Maximale Brennweite {4}
            Übriger Speicherplatz: {5}
            Anzahl der Bilder: {6}
            ",
            Manufacterer, _model, _megapixel, _focalwidthmin, _focalwidthmax, MemoryLeft, AmountOfPictures);             //mit base schließe ich auf die vererbende Klasse zurück
        }
    }
}
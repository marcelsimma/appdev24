using System;

namespace CheyenneHarbarth.Week05.OOP.Fotoapparat
{
    public class FotoapparatAdvanced : IObjekt              //Interface oder Vererbung immer mit :
    {

        private string _model;

        public string Model
        {
            get { return _model; }
            set
            {
                _model = value;
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
        public string Manufacterer;

        public string Inventorynumber { get; }

        public double Price { get; set; }

        public FotoapparatAdvanced(string model, double megapixel, string manufacterer)      //weil der Übergabeparameter an sich nichts mit der Klasse sondern nur mit dem Konstruktor, nachdem das Objekt erstellt wurde, werden die Variablen des Konstruktors gelöscht
        {
            _model = model;
            _megapixel = megapixel;
            Manufacterer = manufacterer;
        }

        Objektiv Lense = new Objektiv("Sony", "3000x", 60, 300);

        Speicherkarte MemoryCard = new Speicherkarte("TB600", "Sony", 1000);

        public void TakePhoto()
        {
            //restlichen Speicherplatz
            double memoryUsage = CalculateMemoryForPictures();
            if (MemoryCard.MemoryLeft - memoryUsage > 0)
            {
                MemoryCard.MemoryLeft -= memoryUsage;
                int face = 2;
                Console.WriteLine("\n3, 2, 1, cheeeeese \n*klick*\n   " + (char)face + "\n  \\|/\n   |\n  / \\");
                MemoryCard.AmountOfPictures++;
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
            ",
            Manufacterer, _model, _megapixel);
        }
    }
}
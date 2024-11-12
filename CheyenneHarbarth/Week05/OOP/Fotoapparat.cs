using System;

namespace CheyenneHarbarth.Week05.OOP
{
    class FotoapparatOOP
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


            Fotoapparat fotoapparat2 = new Fotoapparat();

            fotoapparat2._Hersteller = "Sony";
            fotoapparat2._Modell = "Alpha 6600 Premium";
            fotoapparat2._Megapixel = 24.2;
            fotoapparat2._BrennweiteMin = 80;
            fotoapparat2._BrennweiteMax = 320;

            Console.WriteLine(fotoapparat2.toString());
            fotoapparat2.takePhoto();


            Fotoapparat fotoapparat3 = new Fotoapparat();

            fotoapparat3._Hersteller = "Nikon";
            fotoapparat3._Modell = "Z50II";
            fotoapparat3._Megapixel = 20.9;
            fotoapparat3._BrennweiteMin = 60;
            fotoapparat3._BrennweiteMax = 280;

            Console.WriteLine(fotoapparat3.toString());
            fotoapparat3.takePhoto();
        }
    }
    class Fotoapparat
    {
        int BrennweiteMin;
        int BrennweiteMax;
        string Modell;
        string Hersteller;
        double Megapixel;

        public string _Hersteller
        {
            get => Hersteller;                  //get holt sich den Wert
            set => Hersteller = value;          //mit set kann ich denn Wert durch aufrufen der Variable ändern
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



        public void takePhoto()
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
}
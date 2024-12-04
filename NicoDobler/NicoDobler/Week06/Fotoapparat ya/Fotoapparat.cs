using System;
namespace NicoDobler.Week06
{
  public class Fotoapparat{
 
        public static double brennweiteMin;
        public double brennweiteMax;
        public string model;
        public string hersteller;
                public int megapixel;
 
       
        public Fotoapparat(double BrennweiteMin, double BrennweiteMax, string Model, string Hersteller, int Megapixel)
        {
            brennweiteMin = BrennweiteMin;
            brennweiteMax = BrennweiteMax;
            model = Model;
            hersteller = Hersteller;
            megapixel = Megapixel;
        }
        public double BrennweiteMin
        {
            get;
            set;
        }
 
        public double BrennweiteMax
        {
            get;
            set;
        }
 
        public string Model
        {
            get;
            set;
        }
 
        public string Hersteller
        {
            get;
            set;
        }
 
        public int Megapixel
        {
            get;
            set;
        }
 
        public void TakePhoto()
        {
            Console.WriteLine($"{model} schießt ein Foto mit {megapixel} Megapixeln.");
        }
 
        public string FotoapparatDetails()
        {
            return $"Modell: {model}\nHersteller: {hersteller}\nBrennweite: {brennweiteMin}-{brennweiteMax}mm\nMegapixel: {megapixel} MP";
        }
    }
 
 
}
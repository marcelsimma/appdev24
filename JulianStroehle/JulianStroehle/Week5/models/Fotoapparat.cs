using System;
namespace JulianStroehle.Week5.models
{
    public class Fotoapparat
    {
        string model;
        string producer;
        double megapixel;
        public string Model
        {
            get => model;
        }
        public Fotoapparat(string model, string producer, double megapixel)
        {
            this.model = model;
            this.producer = producer;
            this.megapixel = megapixel;
        }
        public void takePhoto()
        {
            Console.Write(@"
       (in guter Qualität)
               O
              /|\
              / \
");
        }
        public override string ToString()
        {
            return string.Format("Hersteller: {0}, Model: {1}, Megapixel: {2}", producer, model, megapixel);
        }
    }
}
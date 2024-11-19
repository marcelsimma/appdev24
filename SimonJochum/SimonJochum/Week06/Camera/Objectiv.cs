using System;

namespace SimonJochum.Week06.Camera
{
    public class Objectiv : Hardware, IGegenstand
    {
        int MinBrennweite;
        int MaxBrennweite;
        public string Inventarnummer{get; set; }
        public int Anschaffungswert{get; set; }

        public int BrennweiteMin
        {
            get => MinBrennweite;
        }

        public int BrennweiteMax
        {
            get => MaxBrennweite;
        }

        public Objectiv(string model, string brand, string serialNumber, int minBrennweite, int maxBrennweite)
        {
            Model = model;
            Brand = brand;
            SerialNumber = serialNumber;
            MinBrennweite = minBrennweite;
            MaxBrennweite = maxBrennweite;
        }
         public Objectiv(string inventarnummer, int anschaffungswert)
        {
            Inventarnummer = inventarnummer;
            Anschaffungswert = anschaffungswert;
        }

         public override string WriteSerialNumber()
        {
            return "Objektiv-"+ base.WriteSerialNumber();
        }

        public string PrintInventarnummer()
        {
            return $"{Inventarnummer}";
        }

        public int PrintAnschaffungswert()
         {
            return Anschaffungswert;
         }
    }
}
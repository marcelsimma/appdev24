using System;

namespace SimonJochum.Week06.Camera
{
    public class SDCard : Hardware, IGegenstand
    {
        public int VolumeMax;
        public int VolumeUsed;
        int GotMegapixel;
        public string Inventarnummer{get; set;}
        public int Anschaffungswert{get; set;}

        public int MaxVolume
        {
            get => VolumeMax;
        }

        public int UsedVolume
        {
            get => VolumeUsed;
            set => VolumeUsed = value;
        }

        public void GotMegapixelFromCamera(int megapixel)
        {
            GotMegapixel = megapixel;
        }

        public SDCard(string model, string brand, string serialNumber, int volumeMax, int volumeUsed)
        {
            Model = model;
            Brand = brand;
            SerialNumber = serialNumber;
            VolumeMax = volumeMax * 1000;
            VolumeUsed = volumeUsed * 1000;
        }

         public SDCard(string inventarnummer, int anschaffungswert)
        {
            Inventarnummer = inventarnummer;
            Anschaffungswert = anschaffungswert;
        }

        public string PicturesOnSDCard()
        {
            int amountPictures = (int)(UsedVolume / (GotMegapixel * 0.3));
            System.Console.WriteLine("Ein Bild hat " + GotMegapixel * 0.3 + "MB.");
            return "Auf der Speicherkarte befinden sich " + amountPictures + " Bild(er).";
        }

        public string GetVolume()
        {
            return "Auf der Speicherkarte sind " + UsedVolume + "/" + MaxVolume + "MB belegt.";
        }

        public override string WriteSerialNumber()
        {
            return "Speicherkarten-"+ base.WriteSerialNumber();
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
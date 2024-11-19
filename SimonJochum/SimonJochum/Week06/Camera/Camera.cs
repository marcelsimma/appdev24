using System;

namespace SimonJochum.Week06.Camera
{
    public class Camera : Hardware, IGegenstand
    {
        public int Megapixel;
        public Objectiv Objectiv;
        public SDCard Card;
        public string Inventarnummer{get; set; }
        public int Anschaffungswert{get; set; }

        public int getMegapixel
        {
            get => Megapixel;
            set => Megapixel = value;
        }
        public Camera(int megapixel)
        {
            getMegapixel = megapixel;
        }

        public Camera(string model, string brand, string serialNumber, int megapixel, Objectiv objectiv, SDCard card)
        {
            Model = model;
            Brand = brand;
            SerialNumber = serialNumber;
            Megapixel = megapixel;
            Objectiv = objectiv;
            Card = card;
        }

        public Camera(string inventarnummer, int anschaffungswert)
        {
            Inventarnummer = inventarnummer;
            Anschaffungswert = anschaffungswert;
        }

        public string TakePhoto()
        {

            if (Card.MaxVolume >= Card.UsedVolume && Card.MaxVolume-Card.UsedVolume >= Megapixel * 0.3)
            {
                if (Objectiv.BrennweiteMax < 60)
                {
                    Card.UsedVolume += (int)(Megapixel * 0.3);
                    return @"
             ☻    
            /|\ 
            / \ 
            ";
                }
                else
                {
                    Card.UsedVolume += (int)(Megapixel * 0.3);
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
            else
            {
                return "Kein Speicherplatz mehr vorhanden. Bitte Speicherkarte wechseln.";
            }
        }

        public string CameraWhoTookPhoto()
        {
            return "Dieses Foto wurde von der Kamera \"" + Brand + " " + Model + "\" aufgenommen.";
        }
        
        public override string WriteSerialNumber()
        {
            return "Fotoapparat-" + base.WriteSerialNumber();
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
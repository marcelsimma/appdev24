using System;

namespace SimonJochum.Week06.Camera
{
    public class Sitzsack : IGegenstand
    {
        public string Inventarnummer{get; set; }
        public int Anschaffungswert{get; set; }

         public Sitzsack(string inventarnummer, int anschaffungswert)
        {
            Inventarnummer = inventarnummer;
            Anschaffungswert = anschaffungswert;
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
using System;

namespace LucasSchiemann.Week06.Foto
{
    public class Speicher:InventarVerwaltung
    {
        public float Speicherplatz{get;set;}
        
        

        public string InventarNummer { get; set; }

        public string Bezeichnung;
        
        public Speicher(float speicherPlatz, string bezeichnung, int seriennummer)// : base(seriennummer)
        {
            Bezeichnung = bezeichnung;
            Speicherplatz = speicherPlatz;
            
        }

    }


}
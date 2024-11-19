using System;
using LucasSchiemann.Week06.Foto;

namespace LucasSchiemann.Week06.Foto;

public class FotoAparat:Hardware,InventarVerwaltung
{

        public string Bezeichnung { get; set; }

        public string InventarNummer{ get; set; }

        public Speicher Speicher;

        public FotoAparat(string bezeichnung, int seriennummer, Speicher speicherPlatz) : base(seriennummer)
        {
            Bezeichnung = bezeichnung;
            Speicher = speicherPlatz;
        }

        public override string PrintSeriennummer() {
            return "Fotoapparat-" + base.PrintSeriennummer();
        }
        public override string PrintInventarnummer()
        {
            return "Inventarnummer der Fotoapparates.";
            
        }
    }




}

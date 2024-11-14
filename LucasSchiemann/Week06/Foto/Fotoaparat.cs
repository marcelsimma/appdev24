using System;
using LucasSchiemann.Week06.Foto;

namespace LucasSchiemann.Week06.Foto
{
public class FotoAparat:Hardware
{

        public string Bezeichnung { get; set; }

        public Speicher Speicher;

        public FotoAparat(string bezeichnung, int seriennummer, Speicher speicherPlatz) : base(seriennummer)
        {
            Bezeichnung = bezeichnung;
            Speicher = speicherPlatz;
        }

        public override string PrintSeriennummer() {
            return "Fotoapparat-" + base.WriteSeriennummer();
        }
        public override string ToString()
        {

            
        }
    }




}

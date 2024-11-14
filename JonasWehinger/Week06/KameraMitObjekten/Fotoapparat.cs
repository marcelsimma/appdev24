namespace JonasWehinger.Week06.KMO
{
    public class Fotoapparat : Hardware
    {
        public string Bezeichnung { get; set; }
        public Speicherkarte Speicher { get; set; }

        public Fotoapparat(string bezeichnung, string seriennummer, Speicherkarte speicherkarte)
            
            : base(seriennummer)
        {
            Bezeichnung = bezeichnung;
            Speicher = speicherkarte;
        }

        public override string WriteFoto()
        {
            return "Der Fotoapparat: " + seriennummer;
        }
    }
}

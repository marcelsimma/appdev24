
namespace JonasWehinger.Week06.KMO
{

    public class Speicherkarte : Hardware
    {

        
        public string Bezeichnung { get; set; }

        public int Speicherplatz { get; set; }

        public Speicherkarte(string bezeichnung, string seriennummer, int speicherplatz) : base(seriennummer)
        {
            Bezeichnung = bezeichnung;
            Speicherplatz = speicherplatz;
        }

    }
}
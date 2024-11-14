
namespace MarcelSimma.Week06.FOS
{

    /*

    Fotoapparat : Hardware
    Die Klasse Fotoapparat erweitert die Klasse Hardware
    Die Klasse Fotoapparat erbt von der Klasse Hardware
    Alle Attribute und Methoden aus der Klasse Hardware sind automatisch in der Klasse Fotoapparat auch verfügbar
    
    */

    public class Speicherkarte : Hardware, IGegenstand
    {

        public string Inventarnummer { get; set; }
        //Instanzattribute
        public string Bezeichnung { get; set; }

        public int Speicherplatz { get; set; }

        public Speicherkarte(string bezeichnung, string seriennummer, int speicherplatz) : base(seriennummer)
        {
            Bezeichnung = bezeichnung;
            Speicherplatz = speicherplatz;
        }

        public string PrintInventarnummer() {
            return "Inventarnummer der Speicherkarte.";
        }

    }
}
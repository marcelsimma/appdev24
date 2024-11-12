
namespace MarcelSimma.Week06.FOS
{

    /*

    Fotoapparat : Hardware
    Die Klasse Fotoapparat erweitert die Klasse Hardware
    Die Klasse Fotoapparat erbt von der Klasse Hardware
    Alle Attribute und Methoden aus der Klasse Hardware sind automatisch in der Klasse Fotoapparat auch verfügbar
    
    */

    public class Fotoapparat : Hardware, IGegenstand
    {

        //Instanzattribute
        public string Bezeichnung { get; set; }

        public string Inventarnummer { get; set;}

        public Speicherkarte Speicher;

        public Fotoapparat(string bezeichnung, string seriennummer, Speicherkarte speicherkarte) : base(seriennummer)
        {
            Bezeichnung = bezeichnung;
            Speicher = speicherkarte;
        }

        public override string WriteSeriennummer() {
            return "Fotoapparat-" + base.WriteSeriennummer();
        }

        public string PrintInventarnummer() {
            return "";

        }
    }
}
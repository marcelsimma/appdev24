
namespace ManuelHartmann.Week06.FotoapparatErweitert
{
    //  Enthaelt alle Attribute fuer Hardware-Komponenten, welche mit Hardware-Klassen geerbt werden kann.
    public class Hardware
    {
        // In diesen Feld wird der Wert für Modell gespeichert.
        private string _model;

        // Dieses Attribut verwende ich für die Interaktion mit der Außenwelt.
        public string Model
        {
            get
            {
                // Zugriff kontrollieren: Berechtigung vorhanden (Eingeloggt)?
                return _model;
            }
            set
            {
                // Prüfen, ob der neue Wert gewissen Kriterien entspricht. 
                _model = value;
            }
        }
        public string Manufacturer { get; set; }
        public string Seriennummer { get; set; }
    }
}

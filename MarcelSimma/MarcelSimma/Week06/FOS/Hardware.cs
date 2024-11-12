
namespace MarcelSimma.Week06.FOS {

    public class Hardware {

        //Instanzattribute
        public string Seriennummer;
        public string Modell;
        public string Hersteller;

        public Hardware(string seriennummer) {
            Seriennummer = seriennummer;
        }

        public virtual string WriteSeriennummer() {
            return "Seriennummer: " + Seriennummer;
        }
    }
}
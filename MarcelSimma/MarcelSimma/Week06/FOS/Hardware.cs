
namespace MarcelSimma.Week06.FOS {

    public class Hardware {

        //Instanzattribute
        internal string Seriennummer;
        private string Modell;
        private string Hersteller;

        public Hardware(string seriennummer) {
            Seriennummer = seriennummer;
        }

        public virtual string WriteSeriennummer() {
            return "Seriennummer: " + Seriennummer;
        }
    }
}
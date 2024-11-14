namespace JonasWehinger.Week06.KMO
{
    public class Hardware
    {
        public string seriennummer;
        public string modell;
        public string hersteller;

        public Hardware(string seriennummer)
        {
            this.seriennummer = seriennummer;
        }

        public virtual string WriteFoto()
        {
            return "Die Seriennummer: " + seriennummer;
        }
    }
}
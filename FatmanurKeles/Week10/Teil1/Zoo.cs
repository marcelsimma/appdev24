using System;

namespace FatmanurKeles.Week10.Teil1
{
    public class Zoo
    {
        public string ZooName {get; set;}
        public string Gruendungsjahr {get; set;}
        public List<Gehege> GehegeListe; 
        
        public Zoo(string zooname, string gruendungsjahr)
        {
            ZooName = zooname;
            Gruendungsjahr = gruendungsjahr;
            GehegeListe = new List<Gehege>();
        }

        public void FuegeGehege(Gehege gehege)
        {
            GehegeListe.Add(gehege);
        }

        public void EntferneGehege(Gehege gehege)
        {
            GehegeListe.Remove(gehege);
        }

        public override string ToString()
        {
            return 
            String.Format(
                @$"ZooName: {ZooName}
                Gründungsjahr: {Gruendungsjahr}
                Gehege: {GehegeListe}");
        }
    }
}
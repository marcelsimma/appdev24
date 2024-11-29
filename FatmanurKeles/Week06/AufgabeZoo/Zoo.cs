using System;
using FatmanurKeles.Week06.ZOO;

namespace FatmanurKeles.Week06.AufgabeZoo
{
    public class Zoo
    {
        public string Zooname {get; set;}
        public string Gruendungsjahr {get; set;}
        public Gehege Gehegename {get; set;}
        public string Ort {get; set;}

        public Zoo(string zooname, string gruendungsjahr, Gehege gehegename, string ort)
        {
            Zooname = zooname;
            Gruendungsjahr = gruendungsjahr;
            Gehegename = gehegename;
            Ort = ort;
        }

        public override string ToString()
        {
            return
            String.Format(
            @"
            Datenblatt Kamera: 
            
            Name: {0}
            Gruendungsjahr: {1}
            Ort:  {2}
            Gehege: {3}
            "
            , Zooname, Gruendungsjahr, Ort );
            
        }
    }
}

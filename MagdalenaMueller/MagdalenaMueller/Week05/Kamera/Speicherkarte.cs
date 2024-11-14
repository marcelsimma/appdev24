using System;

namespace MagdalenaMueller.Week05
{
    public class Speicherkarte : IGegenstand
    {
        
        public string inventarNumber {get; set;}
        public int costs {get; set;}
        public int availiblespeicher;

        public Speicherkarte(int Availiblespeicher, string inventarnummer, int Costs)
        {
            availiblespeicher = Availiblespeicher;
            inventarNumber = inventarnummer;
            costs = Costs;
        }

        public virtual string WriteSpeicher()
        {
            return $"Speicher: {availiblespeicher}";
        }

        public string PrintInventarnummer()
        {
        
            return $"Speicherkarte:";
        }
    }
}
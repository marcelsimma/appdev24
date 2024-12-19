using System;
using System.Collections.Generic;

namespace JonasWehinger.ZooSimulation
{
    public class Pfleger
    {
        public int PflegerID;
        public string Name;
        public string Arbeitsbereich;
        public string Lieblingstier;
        public Pfleger(int pflegerID, string name, string arbeitsbereich)
        {
            PflegerID = pflegerID;
            Name = name;
            Arbeitsbereich = arbeitsbereich;
        }

        public void KuemmereDichUmGehege(Gehege gehege)
        {
            Console.WriteLine($"Pfleger {Name} kümmert sich um das Gehege: {gehege.Name}");

            if (gehege.Bearbeitet)
            {
                Console.WriteLine($"Gehege {gehege.Name} wurde bereits bearbeitet. {Name} geht weiter.");
                return;
            }

           
            Console.WriteLine($"Pfleger {Name} füttert die Tiere im Gehege {gehege.Name}:");
            foreach (var tier in gehege.Tiere)
            {
                Console.WriteLine($"{tier.Name} ({tier.Spezies}) wird gefüttert.");
            }

            
            var random = new Random();
            int index = random.Next(0, gehege.Tiere.Count);
            var beobachtetesTier = gehege.Tiere[index];
            Lieblingstier = beobachtetesTier.Name;

            Console.WriteLine($"Pfleger {Name} beobachtet {beobachtetesTier.Name} ({beobachtetesTier.Spezies}) länger.");
        }
    }
}

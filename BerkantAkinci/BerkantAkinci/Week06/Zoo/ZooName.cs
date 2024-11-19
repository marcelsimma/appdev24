using System;
using System.Reflection.Metadata.Ecma335;

namespace BerkantAkinci.Week06.Zoo
{
    public class ZooName
    {
        public string _Name;

        public int _Gruendungsjahr;

        public List<Gehege> GehegenListe = new List<Gehege>();

        public ZooName(string name, int gruendungsjahr)
        {
            _Name = name;
            _Gruendungsjahr = gruendungsjahr;
        }

        public void AddGehege(Gehege zooGehege)
        {
            GehegenListe.Add(zooGehege);
        }

        public void RemoveGehege(Gehege zooGehege)
        {
            GehegenListe.Remove(zooGehege);
        }

        public void ZooStruktur()
        {
            Console.WriteLine($"\n|---- Zoo: {_Name}, gegründet {_Gruendungsjahr}");
            if (GehegenListe.Count > 0)
            {
                foreach (Gehege gehege in GehegenListe)
                {
                    Console.WriteLine("|     |---- Gehege: " + gehege._Name);
                    if (gehege.Tiere.Count > 0)
                    {
                        foreach (Tier tier in gehege.Tiere)
                        {
                            Console.WriteLine("|           |---- " + tier.ToString());
                        }
                    }
                    else
                    {
                        Console.WriteLine("|           |---- (leer)");
                    }
                }
            }
            else
            {
                Console.WriteLine("Es sind noch keine Gehege vorhanden!");
            }
        }
    }
}
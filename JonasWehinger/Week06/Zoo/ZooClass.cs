using System;

namespace JonasWehinger.Zoo
{

    public class Zoo
    {
        public string Name { get; set; }
        public int Gruendungsjahr { get; set; }
        public List<Gehege> GehegeListe { get; set; }

        public Zoo(string name, int gruendungsjahr)
        {
            Name = name;
            Gruendungsjahr = gruendungsjahr;
            GehegeListe = new List<Gehege>();
        }

        public void GehegeHinzufuegen(Gehege gehege)
        {
            GehegeListe.Add(gehege);
        }

        public void GehegeEntfernen(Gehege gehege)
        {
            GehegeListe.Remove(gehege);
        }

        public void StrukturAusgeben()
        {
            Console.WriteLine($"├── Zoo: {Name}, gegründet {Gruendungsjahr}");
            foreach (Gehege gehege in GehegeListe)
            {
                Console.WriteLine($"│   ├── Gehege: {gehege.Name}");
            }
        }
    } 
    }

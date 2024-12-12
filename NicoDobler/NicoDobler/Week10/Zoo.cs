using System;
namespace NicoDobler.Week10
{



    public class Zoo
    {
        public string Name;
        public int Gruendungsjahr;
        private List<Gehege> gehegeListe;

        public Zoo(string name, int gruendungsjahr)
        {
            Name = name;
            Gruendungsjahr = gruendungsjahr;
            gehegeListe = new List<Gehege>();
        }

        public void GehegeHinzufuegen(Gehege gehege)
        {
            gehegeListe.Add(gehege);
        }

        public void GehegeEntfernen(Gehege gehege)
        {
            gehegeListe.Remove(gehege);
        }

        public void StrukturAusgeben()
        {
            Console.WriteLine($"├── Zoo: {Name}, gegründet {Gruendungsjahr}");
            foreach (var gehege in gehegeListe)
            {
                Console.WriteLine($"│   ├── Gehege: {gehege.Name}");
            }
        }
    }
}
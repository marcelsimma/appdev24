using System;

namespace CheyenneHarbarth.Week05.OOP.Zoo
{
    public class Zoo
    {
        private string Name;
        public string _Name
        {
            get => Name;
            set => Name = value;
        }

        private int Gründungsjahr;
        public int _Gründungsjahr
        {
            get => Gründungsjahr;
            set => Gründungsjahr = value;
        }

        public List<Gehege> Zoostruktur = new List<Gehege>();

        public Zoo(string name, int gründungsjahr)
        {
            Name = name;
            Gründungsjahr = gründungsjahr;
        }

        public void GehegeHinzufuegen(Gehege _name)
        {
            Zoostruktur.Add(_name);
        }

        public void Gehegelöschen(Gehege _name)
        {
            Zoostruktur.Remove(_name);
        }

        public void Zoodarstellen()
        {
            Console.WriteLine($"\n|--- Zoo: {_Name}, gegründet {_Gründungsjahr}");
            if (Zoostruktur.Count > 0)
            {
                foreach (Gehege gehege in Zoostruktur)
                {
                    Console.WriteLine("|    |--- Gehege: " + gehege._Name);
                    if (gehege.Tiere.Count > 0)
                    {
                        foreach (Tier tier in gehege.Tiere)
                        {
                            Console.WriteLine("|         |--- " + tier.ToString());
                        }
                    }
                    else
                    {
                        Console.WriteLine("|         |--- (leer)");
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
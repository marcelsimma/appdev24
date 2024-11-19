using System;

namespace SimonJochum.Week06.Zoo
{
    public class Zoo
    {
        public string Name { get; set; }
        public string FoundingYear { get; set; }
        public List<Enclosure> Enclosures { get; set; } = new List<Enclosure>();

        public Zoo(string name, string foundingYear)
        {
            Name = name;
            FoundingYear = foundingYear;
        }

        public void AddEnclosure(Enclosure enclosure)
        {
            Enclosures.Add(enclosure);
        }

        public bool RemoveEnclosure(string enclosureName)
        {
            Enclosure enclosure = Enclosures.Find(e => e.Name == enclosureName);
            if (enclosure != null)
            {
                Enclosures.Remove(enclosure);
                return true;
            }
            return false;
        }

        public Enclosure GetEnclosure(string enclosureName)
        {
            return Enclosures.Find(e => e.Name == enclosureName);
        }

        public override string ToString()
        {
            string result = $"Zoo: {Name}, gegründet {FoundingYear}\n";
            foreach (var enclosure in Enclosures)
            {
                result += enclosure.ToString();
            }
            return result;
        }
    }
}

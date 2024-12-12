using System;

namespace SimonJochum.Week10.Zoo.Zoo_Part1
{
    public class Zookeeper
    {
        private string _name { get; set; }
        private List<Enclosure> _enclosures { get; set; }

        public Zookeeper(string name)
        {
            _name = name;
            _enclosures = new List<Enclosure>();
        }
        public List<Enclosure> Enclosures => _enclosures;

        public void AddEnclosure(Enclosure enclosure)
        {
            _enclosures.Add(enclosure);
        }

        public string GetName()
        {
            return "Pfleger: " + _name + "\n";
        }
    }
}
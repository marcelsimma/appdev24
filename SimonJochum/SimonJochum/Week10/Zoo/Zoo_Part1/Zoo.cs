using System;

namespace SimonJochum.Week10.Zoo.Zoo_Part1
{
    public class Zoo
    {
        private string _name { get; set; }
        private DateTime _foundingYear { get; set; }
        private List<Enclosure> _enclosures { get; set; } = new List<Enclosure>();

        public Zoo(string name, DateTime foundingYear)
        {
            _name = name;
            _foundingYear = foundingYear;
        }

        public void AddEnclosure(Enclosure enclosure)
        {
            _enclosures.Add(enclosure);
        }

        public void RemoveEnclosure(string enclosureName)
        {
            Enclosure enclosure = _enclosures.Find(enclosure => enclosure.Name == enclosureName);
            if (enclosure != null)
            {
                _enclosures.Remove(enclosure);
                Console.WriteLine("Gehege entfernt.");
            }
            else
            {
                Console.WriteLine("Gehege nicht gefunden!");
            }
        }

         public string PrintZoo()
        {
            string result = $"Zoo: {_name}, gegründet {_foundingYear.Year}\n";
            foreach (var enclosure in _enclosures)
            {
                result += enclosure.GetName();
            }
            return result;
        }

    }
}
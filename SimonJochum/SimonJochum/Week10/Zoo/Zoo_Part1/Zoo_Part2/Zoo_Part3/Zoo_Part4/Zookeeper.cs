using System;

namespace SimonJochum.Week10.Zoo.Zoo_Part1
{
    public class Zookeeper
    {
        private string _name { get; set; }
        private List<Enclosure> _enclosures { get; set; }
        private Animal _favoriteAnimal { get; set; }

        public Zookeeper(string name)
        {
            _name = name;
            _enclosures = new List<Enclosure>();
        }
        public List<Enclosure> Enclosures => _enclosures;
        public string Name => _name;

        public void AddEnclosure(Enclosure enclosure)
        {
            _enclosures.Add(enclosure);
        }

        public string GetName()
        {
            return "Pfleger: " + _name + "\n";
        }

        public void SetFavoriteAnimal(Animal animal)
        {
            _favoriteAnimal = animal;
        }

        public void SimulateDay(HashSet<string> visitedEnclosures)
        {
            Console.WriteLine($"{_name} beginnt mit der Arbeit.");

            bool hasWorked = false;

            foreach (var enclosure in _enclosures)
            {
                if (hasWorked == false)
                {
                    if (visitedEnclosures.Contains(enclosure.Name))
                    {
                        Console.WriteLine($"{_name} überspringt Gehege {enclosure.Name}, es wurde bereits bearbeitet.");
                        continue;
                    }

                    visitedEnclosures.Add(enclosure.Name);
                    hasWorked = true;
                    Console.WriteLine($"{_name} bearbeitet Gehege {enclosure.Name}.");

                    foreach (var animal in enclosure.Animals)
                    {
                        Console.WriteLine($"{_name} füttert {animal.Name} ({animal.Species}).");
                    }

                    if (enclosure.Animals.Any())
                    {
                        var random = new Random();
                        var favoriteAnimal = enclosure.Animals[random.Next(enclosure.Animals.Count)];
                        _favoriteAnimal = favoriteAnimal;
                        Console.WriteLine($"{_name} beobachtet {favoriteAnimal.Name} ({favoriteAnimal.Species}) genauer.");
                    }
                }
            }

            if (!hasWorked)
            {
                Console.WriteLine($"{_name} hat heute keine Gehege zu bearbeiten.");
            }

            
        }
    }
}
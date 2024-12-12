using System.Dynamic;

namespace BarbaraMarte.Zoo.Part4
{
    class Enclosure
    {
        public string _EnclosureType { get; set; }
        public int _ID { get; set; }
        public List<Animal> _AnimalList { get; set; }

        public Enclosure(string enclosureType)
        {
            _EnclosureType = enclosureType;
            _AnimalList = new List<Animal>();
        }
        public void AddAnimal(Animal animal)
        {
            _AnimalList.Add(animal);
        }
        public void DeleteAnimal(Animal animal)
        {
            _AnimalList.Remove(animal);
        }
    }
}

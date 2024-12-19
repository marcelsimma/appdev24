using System.Dynamic;

namespace BarbaraMarte.Zoo.Part4
{
    class Enclosure
    {
        public string _EnclosureType { get; set; }
        internal int _Id;
        public int _ID { get; set; }
        public List<Animal> _AnimalList { get; set; }

        public Enclosure(string enclosureType, int id)
        {
            _EnclosureType = enclosureType;
            _Id = id;
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

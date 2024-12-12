namespace BarbaraMarte.Zoo.Part2
{
    class Enclosure
    {
        public string _EnclosureType { get; set; }
        public int _ID { get; set; }
        public List<Animal> AnimalList { get; set; }

        public Enclosure(string enclosureType)
        {
            _EnclosureType = enclosureType;
            AnimalList = new List<Animal>();
        }

        public void AddAnimal(Animal animal)
        {
            AnimalList.Add(animal);
        }
        public void DeleteAnimal(Animal animal)
        {
            AnimalList.Remove(animal);
        }

    }
}
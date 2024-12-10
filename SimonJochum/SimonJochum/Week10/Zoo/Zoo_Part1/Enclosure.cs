using System;

namespace SimonJochum.Week10.Zoo.Zoo_Part1
{
    public class Enclosure
    {
        private string _name {get; set;}

        public Enclosure (string name)
        {
            _name = name;
        }
        public string Name => _name;

        public string GetName()
        {
            string result = $"├── Gehege: {Name}\n";
            return result;
        }
    }
}
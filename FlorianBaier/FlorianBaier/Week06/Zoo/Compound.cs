using System;

namespace FlorianBaier.Week06
{
    public class Compound
    {
        public string Name { get; private set; }
        public string Description { get; private set; }

        public Compound(string name, string description)
        {
            Name = name;
            Description = description;
        }
        public virtual void PrintCompoundInfo(int level)
        {
            string indent = new string(' ', level * 2);
            Console.WriteLine($"{indent} Gehege: {Name} ({Description})");
        }
    }
}
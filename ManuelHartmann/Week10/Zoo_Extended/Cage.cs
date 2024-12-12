using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManuelHartmann.Week10.Zoo_Extended
{
    public class Cage
    {
        public string IdCage { get; private set; }
        public string NameCage { get; private set; }
        public string Condition { get; set; }
        public List<Animal> Animals { get; set; }

        public Cage(string idCage, string nameCage, string condition)
        {
            IdCage = idCage;
            NameCage = nameCage;
            Condition = condition;
            Animals = new List<Animal>();
        }

        public void AddAnimal(Animal animal)
        {
            Animals.Add(animal);
        }
        public void RemoveAnimal(Animal animal) 
        {
            if (Animals.Contains(animal))
            {
                Animals.Remove(animal);
            }
            else
            {
                Console.WriteLine($"No need to remove {animal} cause it's not in the List anyway.");
            }
        }
        public override string ToString()
        {
            // Somit wird der ListenInhalt wie gewuenscht ausgegeben.
            // Die 'StringBuilder-Klasse wird verwendet, um effizient eine Zeichenkette zu erstellen, die alle Tier-Objekte auflistet.
            StringBuilder AnimalsDetails = new StringBuilder();
            if (Animals.Count == 0)
            {
                AnimalsDetails.AppendLine($"|       |-- (leer)");
            }
            else
            {
                foreach (Animal animal in Animals)
                {
                    AnimalsDetails.AppendLine($"|       |- {animal}");
                }
            }
            return String.Format(
            @"|    |- Cage: {0}, Condition: {1}
{2}"

        , NameCage, Condition, AnimalsDetails.ToString()
            );
        }
    }
}

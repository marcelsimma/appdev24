using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManuelHartmann.Week10.Zoo_Extended
{
    public class Keeper
    {
        public string NameKeeper { get; private set; }
        public string IdKeeper { get; private set; }
        public List<Cage> Cages { get; set; }

        public Keeper(string idKeeper, string nameKeeper)
        {
            IdKeeper = idKeeper;
            NameKeeper = nameKeeper;
            Cages = new List<Cage>();
        }

        public void AddCage(Cage cage) 
        { 
            Cages.Add(cage); 
        }
        public void RemoveCage(Cage cage)
        {
            if (Cages.Contains(cage))
            {
                Cages.Remove(cage);
            }
            else
            {
                Console.WriteLine($"No need to remove {cage} cause it's not in the List anyway.");
            }
        }
        public override string ToString()
        {
            // Somit wird der ListenInhalt wie gewuenscht ausgegeben.
            // Die 'StringBuilder-Klasse wird verwendet, um effizient eine Zeichenkette zu erstellen, die alle Tier-Objekte auflistet.
            StringBuilder CageDetails = new StringBuilder();
            if (Cages.Count == 0)
            {
                CageDetails.AppendLine($"|       |-- (leer)");
            }
            else
            {
                foreach (Cage cage in Cages)
                {
                    CageDetails.AppendLine($"{cage}");
                }
            }
            return String.Format(
            @"|   |- Keeper: {0}
{1}"

        , NameKeeper, CageDetails.ToString()
            );
        }
    }
}

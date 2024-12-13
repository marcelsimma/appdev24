using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManuelHartmann.Week10.Zoo_Extended
{
    public class Zoo
    {
        public string NameZoo { get; private set; }
        public string FoundationZoo { get; private set; }
        public string IdZoo { get; private set; }

        public double CalcFood = 0;
        public List<Keeper> Keepers { get; set; }
        public List<Cage> Cages { get; set; }
        public Dictionary<AnimalFood, double> FoodDemand { get; set; }

        public Zoo(string idZoo, string nameZoo, string foundationZoo)
        {
            IdZoo = idZoo;
            NameZoo = nameZoo;
            FoundationZoo = foundationZoo;
            Keepers = new List<Keeper>();
            Cages = new List<Cage>();
            FoodDemand = new Dictionary<AnimalFood, double>();
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
        public void AddKeeper(Keeper keeper)
        {
            Keepers.Add(keeper);
        }
        public void RemoveKeeper(Keeper keeper)
        {
            if (Keepers.Contains(keeper))
            {
                Keepers.Remove(keeper);
            }
            else
            {
                Console.WriteLine($"No need to remove {keeper} cause it's not in the List anyway.");
            }
        }
        public string CalcSumFood()
        {
            // Jede Futterposition
            foreach (var food in FoodDemand)
            {
                // Anzahl jeder Futterposition
                for (int i = 0; i < food.Value; i++)
                {
                    CalcFood += food.Key.UnitPrice; // Aufsummierung des Gesamtbetrags-Futter.
                }
            }
            return $"The whole food costs: {CalcFood:F2}";
        }
        public override string ToString()
        {
            // Somit wird der ListenInhalt wie gewuenscht ausgegeben.
            // Die 'StringBuilder-Klasse wird verwendet, um effizient eine Zeichenkette zu erstellen, die alle Keeper-Objekte auflistet.
            StringBuilder KeeperDetails = new StringBuilder();
            if (Keepers.Count == 0)
            {
                KeeperDetails.AppendLine($"(leer)");
            }
            else
            {
                foreach (Keeper kepper in Keepers)
                {
                    KeeperDetails.AppendLine($"{kepper}");
                }
            }

            //StringBuilder CagesDetails = new StringBuilder();
            //if (Cages.Count == 0)
            //{
            //    CagesDetails.AppendLine($"(leer)");
            //}
            //else
            //{
            //    foreach (Cage cage in Cages)
            //    {
            //        CagesDetails.AppendLine($"{cage}");
            //    }
            //}

            StringBuilder FoodDemandDetails = new StringBuilder();
            if (FoodDemand.Count == 0)
            {
                FoodDemandDetails.AppendLine($"|       |-- (leer)");
            }
            // Ausgabe Dictionary.
            foreach (var food in FoodDemand)
            {
                FoodDemandDetails.AppendLine($"Product: {food.Key.NameFood}/{food.Key.Amount}{food.Key.Unit}/{food.Key.UnitPrice}€, Quantity: {food.Value}");
            }

            return String.Format(
            @"|- Zoo: {0}, {1}
{2}
{3}
{4}€."

        , NameZoo, FoundationZoo, KeeperDetails.ToString(), FoodDemandDetails.ToString(), CalcSumFood()
            );
        }
    }
}

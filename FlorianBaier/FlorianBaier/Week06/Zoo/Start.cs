using System;

namespace FlorianBaier.Week06
{

    public class Start
    {
        public static void Launch()
        {
            Zoo meinZoo = new Zoo("Tiergarten Dornbirn", 2022);

            Compound alpenwiese = new Compound("Alpenwiese", "Offenes Gelände mit typischen Alpenpflanzen");
            Compound ried = new Compound("Ried", "Feuchtgebiet mit Vögeln und Amphibien");
            Compound terrarium = new Compound("Terrarium", "Warmraum für tropische Tiere");

            meinZoo.AddCompound(alpenwiese);
            meinZoo.AddCompound(ried);
            meinZoo.AddCompound(terrarium);

            meinZoo.PrintZooStructure();

            meinZoo.RemoveCompound(ried);

            Console.WriteLine("\nNach dem Entfernen eines Geheges:");
            meinZoo.PrintZooStructure();
        }
    }
}
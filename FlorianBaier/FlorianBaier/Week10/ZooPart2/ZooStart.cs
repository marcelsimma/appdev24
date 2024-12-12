using System;

namespace FlorianBaier.Week10.ZooPart2
{
    internal class ZooStart
    {
        public static void Start()
        {
            Zoo zoo = new Zoo("Tiergarten Dornbirn", "2022");

            Enclosure alpenwiese = new Enclosure("Alpenwiese");
            Enclosure ried = new Enclosure("Ried");
            Enclosure terrarium = new Enclosure("Terrarium (warm)");

            zoo.AddEnclosure(alpenwiese);
            zoo.AddEnclosure(ried);
            zoo.AddEnclosure(terrarium);

            Animal rijska = new Animal("Rijska", "Kuh");
            Animal garmond = new Animal("Garmond", "Storch");
            Animal hugo = new Animal("Hugo", "Storch");
            Animal idaxis = new Animal("Idaxis", "Storch");

            alpenwiese.AddAnimal(rijska);
            ried.AddAnimal(garmond);
            ried.AddAnimal(hugo);
            ried.AddAnimal(idaxis);

            zoo.StructureInfo();

            ried.DeleteAnimal("Hugo");
            zoo.DeleteEnclosure("Ried");

            Console.WriteLine("\nStructureinfo after deleting 'Hugo' and 'Ried' enclosure:");
            zoo.StructureInfo();
        }
    }

}
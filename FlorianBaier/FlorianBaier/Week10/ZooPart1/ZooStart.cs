using System;

namespace FlorianBaier.Week10
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

            zoo.StructureInfo();

            zoo.DeleteEnclosure(ried);

            Console.WriteLine("\nStructureinfo after deleting 'Ried':");
            zoo.StructureInfo();
        }

    }
}
using System;
using System.Text;

namespace FlorianBaier.Week10.ZooPart3
{
    internal class ZooStart
    {
        public static void Start()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Food hay = new Food("Heu", "kg", 10.00);
            Food water = new Food("Wasser", "L", 2.00);
            Food fruits = new Food("Früchte", "kg", 5.00);

            Animal lion = new Animal("Leo", "Löwe");
            Animal elephant = new Animal("Ella", "Elefant");

            lion.AddFood(hay, 15.0);
            lion.AddFood(water, 30.0);

            elephant.AddFood(hay, 30.0);
            elephant.AddFood(fruits, 10.0);

            Enclosure savanna = new Enclosure("Savanna");
            savanna.AddAnimal(lion);

            Enclosure jungle = new Enclosure("Jungle");
            jungle.AddAnimal(elephant);

            Zoo zoo = new Zoo("Tiergarten Dornbirn", DateTime.Now);
            zoo.AddEnclosure(savanna);
            zoo.AddEnclosure(jungle);

            Console.WriteLine("Zoo Structure:");
            zoo.StructureInfo();

            zoo.DisplayZooFoodCost();

            savanna.DeleteAnimal("Leo", zoo);
            Console.WriteLine("\nAfter deleting 'Leo':");
            zoo.StructureInfo();
            zoo.DisplayZooFoodCost();

            zoo.DeleteEnclosure("Jungle");
            Console.WriteLine("\nAfter deleting 'Jungle' enclosure:");
            zoo.StructureInfo();
            zoo.DisplayZooFoodCost();
        }
    }
}
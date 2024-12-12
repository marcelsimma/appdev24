using System;
using System.Text;

namespace FlorianBaier.Week10.ZooPart4
{
    internal class ZooStart
    {
        public static void Start()
        {   
            Console.Clear();
            Console.OutputEncoding = Encoding.UTF8;
            Food hay = new Food("Hay", "kg", 10.00);
            Food water = new Food("Water", "L", 2.00);
            Food fruits = new Food("Fruits", "kg", 5.00);
            Food meat = new Food("Meat", "kg", 30.00);

            Animal lion = new Animal("Leo", "Lion");
            Animal elephant = new Animal("Ella", "Elephant");
            Animal snowwolf = new Animal("Gabriel", "Wolf");

            lion.AddFood(hay, 15.0);
            lion.AddFood(water, 30.0);
            lion.AddFood(meat, 25.5);

            elephant.AddFood(hay, 30.0);
            elephant.AddFood(fruits, 10.0);

            snowwolf.AddFood(meat, 23.6);
            snowwolf.AddFood(water, 15.7);

            Enclosure savanna = new Enclosure("Savanna");
            savanna.AddAnimal(lion);

            Enclosure jungle = new Enclosure("Jungle");
            jungle.AddAnimal(elephant);

            Enclosure snowtundra = new Enclosure("Snowtundra");
            snowtundra.AddAnimal(snowwolf);

            Zoo zoo = new Zoo("Tiergarten Dornbirn", DateTime.Now);
            zoo.AddEnclosure(savanna);
            zoo.AddEnclosure(jungle);
            zoo.AddEnclosure(snowtundra);

            Zookeeper zookeeper1 = new Zookeeper("Berkant Akinci");
            zookeeper1.AssignToEnclosure(savanna);
            zookeeper1.AssignToEnclosure(jungle);
            zookeeper1.AssignToEnclosure(snowtundra);

            Zookeeper zookeeper2 = new Zookeeper("Alessio Gaudio");
            zookeeper2.AssignToEnclosure(savanna);

            zoo.AddKeeper(zookeeper1);
            zoo.AddKeeper(zookeeper2);  

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
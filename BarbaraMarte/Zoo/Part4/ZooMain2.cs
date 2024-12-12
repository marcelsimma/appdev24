namespace BarbaraMarte.Zoo.Part4
{
    class ZooMain4
    {
        public static void Start()
        {
            // ZooUserInput zooUserInput = new ZooUserInput();
            // zooUserInput.Start();

            System.Console.WriteLine();
            ZooInfo zooInfo1 = new ZooInfo("WildparkFeldkirch", DateTime.Now);

            Enclosure forest = new Enclosure("Forest");
            Enclosure ocean = new Enclosure("Ocean");

            Animal forestAnimal1 = new Animal("Fox", "Fred");
            Animal forestAnimal2 = new Animal("Fox", "Ida");
            Animal forestAnimal3 = new Animal("Deer", "Ingo");
            Animal forestAnimal4 = new Animal("Mosquito", "Asshole");

            Animal oceanAnimal = new Animal("Orca", "Oscar");

            AnimalFood meat = new AnimalFood("kg", "Meat", 6.0);
            AnimalFood fish = new AnimalFood("kg", "Fish", 10.99);
            AnimalFood gras = new AnimalFood("kg", "Gras", 1.5);
            AnimalFood blood = new AnimalFood("l", "Blood", 9.90);
            AnimalFood water = new AnimalFood("l", "Water", 1.5);

            Zookeeper Julian = new Zookeeper("Julian");
            Zookeeper Lova = new Zookeeper("Lova");

            forestAnimal1.AddFood(meat, 10);
            forestAnimal2.AddFood(meat, 5);
            forestAnimal3.AddFood(gras, 1);
            forestAnimal4.AddFood(blood, 1);
            oceanAnimal.AddFood(fish, 8);

            forest.AddAnimal(forestAnimal1);
            forest.AddAnimal(forestAnimal2);
            forest.AddAnimal(forestAnimal3);
            forest.AddAnimal(forestAnimal4); 
            ocean.AddAnimal(oceanAnimal);

            zooInfo1.AddEnclosure(forest);
            zooInfo1.AddEnclosure(ocean);

            zooInfo1.AddZookeeper(Julian);
            zooInfo1.AddZookeeper(Lova);

            Julian.AddEnclosureZookeeper(forest);
            Lova.AddEnclosureZookeeper(ocean);

            zooInfo1.StructureInfo();
            /*            
                        double totalConsumption1 = forestAnimal1.CalculateFoodConsumption() + forestAnimal2.CalculateFoodConsumption();
                        double totalConsumption2 = oceanAnimal.CalculateFoodConsumption();
                        double totalConsumption3 = forestAnimal1.CalculateFoodConsumption() + forestAnimal2.CalculateFoodConsumption() + oceanAnimal.CalculateFoodConsumption();
                        System.Console.WriteLine($@"
                        Daily food consumption Meat: {totalConsumption1,8:F2} kg  
                        Fish:                        {totalConsumption2,8:F2} kg
                        ---------------------------------------- 
                        Total food usage per Day:    {totalConsumption3,8:F2} kg");

            */
            System.Console.WriteLine();
        }
    }
}
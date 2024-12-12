namespace BarbaraMarte.Zoo.Part2
{
    class ZooMain2
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
            Animal oceanAnimal = new Animal("Orca", "Oscar");

            forest.AddAnimal(forestAnimal1);
            forest.AddAnimal(forestAnimal2);
            ocean.AddAnimal(oceanAnimal);

            zooInfo1.AddEnclosure(forest);
            zooInfo1.AddEnclosure(ocean);

            zooInfo1.StructureInfo();
        }
    }
}
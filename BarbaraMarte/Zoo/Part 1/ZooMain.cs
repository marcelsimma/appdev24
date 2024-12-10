namespace BarbaraMarte.Zoo.Part1
{
    class ZooMain
    {
        public static void Start()
        {
            // ZooUserInput zooUserInput = new ZooUserInput();
            // zooUserInput.Start();

            System.Console.WriteLine();
            ZooInfo zooInfo1 = new ZooInfo("WildparkFeldkirch", DateTime.Now);
            Enclosure forest = new Enclosure("Forest");
            Enclosure ocean = new Enclosure("Ocean");

            zooInfo1.AddEnclosure(forest);
            zooInfo1.AddEnclosure(ocean);

            zooInfo1.StructureInfo();
            System.Console.WriteLine();

        }
    }
}
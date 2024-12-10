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
            ZooInfo zooInfo2 = new ZooInfo("Zoo Dornbirn", DateTime.Now);
            System.Console.WriteLine(zooInfo1);
            System.Console.WriteLine();

            List<ZooInfo> zooInfoList = new List<ZooInfo>();

            zooInfoList.Add(zooInfo1);
            zooInfoList.Add(zooInfo2);

            foreach (var tmp in zooInfoList)
            {
                System.Console.WriteLine(tmp);
            }



            Enclosure enclosure1 = new Enclosure("Forest");
            Enclosure enclosure2 = new Enclosure("Ocean");

            for (int i = 0; i < zooInfoList.Count(); i++)
            {
                if (zooInfoList[i]._ZooName == enclosure1)
                {

                }
            }


            System.Console.WriteLine(enclosure1);
            System.Console.WriteLine(enclosure2);


        }
    }
}
namespace BarbaraMarte.Zoo.Part1
{
    class ZooUserInput
    {
        public List<Enclosure> EnclosureList = new List<Enclosure>();
        public void Start()
        {
            bool decision = true;
            while (decision == true)
            {
                Console.Clear();
                System.Console.WriteLine(@"
            Add Enclosure = 1
            Remove Enclosure = 2
            Print out all Enclosures = 3
            Leave Program = E
            ");
                string input = Console.ReadLine() ?? "";
                switch (input.ToLower())
                {
                    case "1":
                        AddEnclosure1();
                        break;
                    case "2":
                        RemoveEnclosure();
                        break;
                    case "3":
                        PrintOutEnclosures1();
                        break;
                    case "e":
                        decision = false;
                        break;
                }
            }
        }
        public void PrintOutEnclosures1()
        {
            foreach (var tmp in EnclosureList)
            {
                System.Console.WriteLine(tmp);
            }
        }
        public void AddEnclosure1()
        {
            System.Console.WriteLine("Which Enclosure do you want to add?");
            string inputEnclosure = Console.ReadLine() ?? "";
            Enclosure enclosure = new Enclosure(inputEnclosure);
            EnclosureList.Add(enclosure);
        }
        public void RemoveEnclosure()
        {
            System.Console.WriteLine("Which Enclosure do you want to remove?");
            string removeEnclosure = Console.ReadLine() ?? "";
            bool enclosureFound = false;

            for (int i = 0; i < EnclosureList.Count; i++)
            {
                if (EnclosureList[i]._EnclosureType == removeEnclosure)
                {
                    EnclosureList.RemoveAt(i);
                    System.Console.WriteLine(removeEnclosure + " has been removed");
                    enclosureFound = true;
                }
            }
            if (enclosureFound == false)
            {
                System.Console.WriteLine("I am sorry, this Enclosure does not exist.");
            }

        }




        public Enclosure? SearchForEnclosure()
        {
            string searchEnclosure = Console.ReadLine() ?? "";

            for (int i = 0; i < EnclosureList.Count; i++)
            {
                if (EnclosureList[i]._EnclosureType == searchEnclosure)
                {
                    return EnclosureList[i];
                }
            }

            return null;
        }
    }
}
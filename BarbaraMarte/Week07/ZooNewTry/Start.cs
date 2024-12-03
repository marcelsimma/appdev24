namespace BarbaraMarte.Week07.ZooNewTry;


class Zoo
{
    public static void Start()
    {
        bool run = true;
        Console.WriteLine("Add Animal 1, Search Animal 2, delete Animal 3, leave 4");
        char input = Convert.ToChar(Console.ReadLine());
        while (run == true)
        {
            switch (input)
            {
                case '1':
                    Animal.AddAnimal();
                    break;
                case '2':

                    break;
                case '3':

                    break;
                case '4':
                    System.Console.WriteLine("Goodby!");
                    run = false;
                    break;
                default:
                    System.Console.WriteLine("Wrong Input. Try again!");
                    break;

            }
        }
    }
}
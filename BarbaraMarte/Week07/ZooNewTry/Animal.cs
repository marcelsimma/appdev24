namespace BarbaraMarte.Week07.ZooNewTry;

class Animal : Enclosure
{

    public static List<string> AnimalInformation = new List<string>();
    public static void AddAnimal()
    {
        Console.WriteLine("Race:");
        string? animalRace = Console.ReadLine();
        Console.WriteLine("Name:");
        string? animalName = Console.ReadLine();

        AnimalInformation.Add($"Animal Name: {animalName}, Animal Race: {animalRace}");
        Console.WriteLine(AnimalInformation);
        AnimalInformation.Add(ChooseEnclosure());

    }
    public static string ChooseEnclosure()
    {
        Console.WriteLine("Which Enclosure do you want to enter? Ocean 1, Forest 2, Mountain 3");
        char inputEnclosure = Convert.ToChar(Console.ReadLine());
        switch (inputEnclosure)
        {
            case '1':
                Enclosure OceanEnclosure;
                break;
            case '2':

                break;
            case '3':

                break;
            default:
                System.Console.WriteLine("Wrong Input. Try again!");
                break;
        }
        return "";
    }
}
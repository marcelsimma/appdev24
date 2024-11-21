namespace BarbaraMarte.Week06.Zoo;

public class PrintZoo
{
    public static void Start()
    {
        List<ZooCage> zooCages = new List<ZooCage>();

        char decision = Convert.ToChar(Console.ReadLine());

        do
        {
            switch (decision)
            {
                case '1':
                    zooCages.Add(ReadAnimal());
                    break;
                case '2':
                    zooCages.Remove(RemoveAnimal());
                    break;
                case '3':
                default:
                    Console.WriteLine("Invalid Input. Please try again");
                    break;
            }
        } while (decision != '4');

    }
    public static ZooCage ReadAnimal()
    {
        Console.WriteLine("Cage, animal race, animal name");
        string cage = Console.ReadLine();
        string? animalRace = Console.ReadLine();
        string? animalName = Console.ReadLine();

        ZooCage zooCage1 = new ZooCage(cage, animalRace, animalName);
        return zooCage1;
    }
    public static ZooCage RemoveAnimal()
    {
        bool input = false;
        ZooCage zooCage = new ZooCage("", "", "");
        Console.WriteLine("Which animal do you want to remove from your list?");
        string? read = Console.ReadLine();
        return zooCage;
    }
}
namespace BarbaraMarte.Week06.Zoo;

public class ZooCage
{
    public string Cage { get; set; }
    public string AnimalName { get; set; }
    public string AnimalRace { get; set; }

    public ZooCage(string cage, string animalRace, string animalName)
    {
        Cage = cage;
        AnimalName = animalName;
        AnimalRace = animalRace;
    }

    public override string ToString() 
    {

        return $"Cage: {Cage,-10} Race of the Animal: {AnimalRace,-15} Name of the Animal: {AnimalName,-15} ";
    }
}
using System.Reflection.Emit;
using System.Reflection.Metadata;

namespace BarbaraMarte.Schule;

class Recipe
{
    private List<Ingredient> Ingredients = [];
    public void CountTheIngredients()
    {
        char answer;
        int numOfItems = 0;
        do
        {
            Console.WriteLine("Please enter the ingredient:");
            var Name = Console.ReadLine();

            Console.WriteLine("How much of do you want to add from the certain ingredient?");
            var Amount = Convert.ToInt32(Console.ReadLine() ?? "0"); // die Fragezeichen sind ein: Null coalescing operator. Falls vorne Null ist, DANN nimm den hinteren Wert.

            Console.WriteLine("Please enter the Unit:");
            var Unit = Console.ReadLine();

            if (Name is null || Unit is null)
            {
                // no more lines readable
                break;
            }

            var ingredient = new Ingredient(Name, Amount, Unit);
            this.Ingredients.Add(ingredient);

            Console.WriteLine(ingredient);

            Console.WriteLine("Do you want to add an other ingredient? (j/n)");
            answer = Convert.ToChar(Console.ReadLine());

            numOfItems++;
        } while (answer == 'j');


        // Console.WriteLine(output);
    }
}
class Ingredient
{
    public string Name;
    public int Amount;
    public string Unit;

    public Ingredient(string name, int amount, string unit)
    {
        this.Name = name;
        this.Amount = amount;
        this.Unit = unit;
    }

    public override string ToString()
    {
        return $"Ingredient: {Name}, Amount: {Amount}, Unit: {Unit}";
    }
}
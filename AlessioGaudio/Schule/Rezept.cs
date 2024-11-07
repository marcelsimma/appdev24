using System;
using System.Collections.Generic;

namespace AlessioGaudio.Week04
{

    public class REZEPT
    {

        public static void Start()
        {
            Recipe recipe = new Recipe();


            while (true)
            {
                Console.Write("Gib eine Zutat ein: ");
                string ingredient = Console.ReadLine();
                recipe.AddIngredient(ingredient);

                Console.Write("Noch eine Zutat? (y/n): ");
                if (Console.ReadLine().ToLower() != "y")
                {
                    break;
                }
            }

            recipe.DisplayIngredients();
        }
    }
}
public class Recipe
{
    private List<string> ingredients = new List<string>();

    public void AddIngredient(string ingredient)
    {
        ingredients.Add(ingredient);
    }

    public void DisplayIngredients()
    {
        Console.WriteLine("Deine Zutaten:");
        foreach (var ingredient in ingredients)
        {
            Console.WriteLine("- " + ingredient);
        }
    }
}


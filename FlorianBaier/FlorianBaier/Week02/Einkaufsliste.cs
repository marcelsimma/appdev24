using System;

namespace FlorianBaier.Week02
{

    public class Einkaufsliste
    {

            public static void PrintEinkaufsliste()
            {
                List<(int value, string element)> shoppinglist = new List<(int, string)>();

                while (true)
                {
                    Console.Write("Geben Sie das Element (oder 'stop' zum Beenden) ein: ");
                    string element = Console.ReadLine();

                    if (element.ToLower() == "stop")
                        break;

                    Console.Write($"Geben Sie die Menge für {element} ein: ");
                    string valueInput = Console.ReadLine();
                    int value;

                    while (!int.TryParse(valueInput, out value))
                    {
                        Console.Write("Bitte geben Sie eine gültige Zahl für die Menge ein: ");
                        valueInput = Console.ReadLine();
                    }
                    shoppinglist.Add((value, element));
                }

                Console.WriteLine("\nShoppinglist:");
                foreach (var item in shoppinglist)
                {
                    Console.WriteLine($"{item.value,5} {item.element}");
                }
                Console.WriteLine("----------------------------");
                Console.WriteLine($"{shoppinglist.Count} Elemente auf der Liste");
            }
            public static void EinkaufslisteNonDynamic(){
                int menge = 0;
                
            }
    }
}


namespace ManuelHartmann.Week02
{

    public class ShoppingList
    {
        public static Dictionary<string, int> shoppingList = new Dictionary<string, int>();
        static void Start(string[] args)
        {
            MenuCases();
            AddItemToShoppingList();
            OverviewShoppingList();
            EditShoppingList();
        }
        public static void MenuCases()
        {
            string response = "";

            do
            {
                Console.Clear();
                BuildMenu();
                response = Console.ReadLine();
                switch (response)
                {
                    case "1":
                        AddItemToShoppingList();
                        break;
                    case "2":
                        OverviewShoppingList();
                        break;
                    case "3":
                        EditShoppingList();
                        break;
                    case "4":
                        shoppingList.Clear();
                        break;
                    case "exit":
                        break;
                    default:
                        Console.WriteLine("Please enter a valid option. Continue by pressing \"enter\".");
                        Console.ReadLine();
                        break;
                }

            } while (response != "exit");
        }

        public static void BuildMenu()
        {
            Console.WriteLine("1. Insert new Item to shoppingList: ");
            Console.WriteLine("2. View whole shoppingList: ");
            Console.WriteLine("3. Edit shoppingList: ");
            Console.WriteLine("4. Emty whole list. \n");
            Console.WriteLine("Please choose an option by pressing 1, 2, 3 or \"enter\".");
        }
        // Gibt dem User die Moeglichkeit Artikel der Einkaufsliste hinzuzufuegen.
        public static void AddItemToShoppingList()
        {
            Console.Clear();
            string responseItem = "";
            do
            {
                Console.WriteLine("Please insert your item you'd like to add:\n" + new string('-', 25) + "\nType \"exit\" if you're done. ");
                responseItem = Console.ReadLine();
                if(responseItem.ToLower() != "exit")
                {
                    // shoppingList.Add(responseItem.ToLower(), 1);
                    Console.WriteLine("Please insert how many pices of the item you'd like to add: ");
                    string respond = Console.ReadLine();
                    if (int.TryParse(respond, out int number))
                    {
                        shoppingList[responseItem.ToLower()] = number;
                    }
                }
            } while (responseItem != "exit");
        }

        // Gibt eine Auflistung ueber alle Artikel in der Shoppingliste.
        public static void OverviewShoppingList()
        {
            Console.Clear();
            foreach (var item in shoppingList)
            {
                // Die if-Abrage macht, dass die Ausgabe links-Buendig ist!
                // Wird ein 'int' verwendet -> keine Kommastelle. Wie oft durch 10 Teilbar, dass man die Kommastellen hat. (Eingabe darf nicht groesser 19 sein)
                int tmp = item.Value;
                if (tmp > 0)
                {
                    tmp = tmp / 10;
                }
                Console.WriteLine($"{(new string(' ', 6 - tmp))} {item.Value}:{item.Key}");
            }
            Console.WriteLine(new string('-', 25));
            if (shoppingList.Count <= 1)
            {
                Console.WriteLine(shoppingList.Count + " element's contained in the list.");
            }
            else
            {
                Console.WriteLine(shoppingList.Count + " elements're contained in the list.");
            }
            Console.ReadLine ();
        }

        // Erlaubt dem User das Value der Artikel zu aendern oder sie zu entfernen.
        public static void EditShoppingList()
        {
            string response = "";
                Console.Clear();
            foreach (var item in shoppingList)
            {
                // Die if-Abrage macht, dass die Ausgabe links-Buendig ist!
                // Wird ein 'int' verwendet -> keine Kommastelle. Wie oft durch 10 Teilbar, dass man die Kommastellen hat. (Eingabe darf nicht groesser 19 sein)
                int tmp = item.Value;
                if (tmp > 0)
                {
                    tmp = tmp / 10;
                }
                Console.WriteLine($"{(new string(' ', 6 - tmp))} {item.Value}:{item.Key}");
            }
            while (response != "exit")
            {
                Console.WriteLine("Please insert the name of the Item you'd like to change it's value: \n" + new string('-', 25) + "\nType \"exit\" to leave ");
                response = Console.ReadLine();
                if (response.ToLower() != "exit")
                {
                    response = response.ToLower();
                    Console.WriteLine("Insert value. (To remove change value to zero)");
                    string tmp = Console.ReadLine();
                    if (int.TryParse(tmp, out int value))
                    {
                        if (shoppingList.ContainsKey(response) && (response != "exit"))
                        {
                            if (value > 0)    // Wird ueberprueft, ob das 'value' groesser 0 ist.
                            {
                                shoppingList[response] = value; // Anpassung des eingegebenen values.
                            }
                            else
                            {
                                shoppingList.Remove(response);  // Entfernen des eingegebenen Artikels.
                            }
                        }
                    }
            else
                {
                Console.WriteLine("The Task you'd like to edit does't exist in the list.");
                }
            }
        }
        }
    }
}





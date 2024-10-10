using System;

namespace SimonJochum.Week02
{
    public class ShoppingList
    {
        public static void Start()
        {
            string shoppingList = "";
            bool finish = false;
            int countArticle = 0;

            Console.WriteLine("Willkommen zu der Einkaufsliste.");

            while (!finish)
            {
                Console.Write("Gib ein Artikel ein (oder 'fertig' zum Beenden) ");
                string? article = Console.ReadLine();

                if (article == "fertig") //Wenn der User "fertig" eintippt wird das Programm beendet und die Einkaufsliste wird ausgegeben bzw. while Schleife wird beendet
                {
                    finish = true;
                }
                else
                {
                    Console.Write("Gib die Menge ein: ");
                    string? amount = Console.ReadLine();

                    while (!int.TryParse(amount, out _)) //hier wird überprüft ob der User für die Menge wirklich eine Zahl eingegeben hat, der _ signalisiert das ich mit dem Rückgabewert von TryParse nichts anfangen möchte.
                    {
                        Console.WriteLine("Bitte gib eine gültige Zahl für die Menge ein.");
                        amount = Console.ReadLine();
                    }

                    shoppingList += $"{string.Format("{0,10}", amount)} {string.Format("{0,-10}", article)}\n"; //string.Format um den String zu formatieren, positiver Wert formatiert rechtsbündig, negativ linksbündig
                    countArticle += 1;


                }
            }
            Console.WriteLine("\n\tEinkaufsliste:");
            Console.Write(shoppingList); //.Write wird hier verwendet da in der Shoppingliste schon ein Zeilenumbruch drinnen ist.
            Console.WriteLine("----------------------");
            Console.WriteLine($"{countArticle} Artikel sind auf der Liste");

        }


    }
}
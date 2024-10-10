using System;
using System.Diagnostics;
using System.Xml;

namespace CheyenneHarbarth.Week02
{

    class Einkaufsliste
    {

        public static void PrintList()
        {
            while (true)
            {
                AskWhat();
                AskHowmany();
                if (AskWhat() == "Liste")
                {            //Problem: fragt doppelt ab was musst du noch einkaufen
                    break;                            //gibt nichts zurück und bricht die while-Schleife ab
                }
            }
            string output = "Deine Einkaufliste lautet: \n\n";
            char addNewItem;
            int numOfItems = 0;

            Console.Write(output);
            Console.Write(@$"--------------------------
            Anzahl der Elemente: {numOfItems}");
        }

        public static string AskWhat()
        {
            Console.WriteLine("Was musst du noch einkaufen?");
            string userinput = Console.ReadLine();
            //output += $"{userinput,-5}";
            return userinput;                           //return "speichert" das definierte in der Methode ab, dies kann ich dann seperat in einer anderen Varibale speichern, danach ist der return-wert aus der Methode "gelöscht" und die Methode ist wieder "leer"

        }

        public static int AskHowmany()
        {
            while (true)
            {
                Console.WriteLine($"Wieviel brauchst du davon?");
                string muchness = Console.ReadLine();

                // Versuche, die Eingabe als Integer zu konvertieren, gibt dann true oder false zurück
                if (int.TryParse(muchness, out int muchness2) /*|| muchness == 0*/)
                {
                    //output += $"{muchness,6} ";
                    return muchness2;
                }
                else
                {
                    // Wenn die Konvertierung fehlschlägt, gib eine Fehlermeldung aus
                    Console.WriteLine($"Das war keine gültige Zahl.");
                }
            }
        }
    }
}



/* class ShoppingList
{
    public static void Start()
    {
        // Liste zur Speicherung der Einkaufsliste
        string output = "Deine Einkaufliste lautet: \n\n";
        char addNewItem;
        int numOfItems = 0;
        
        // Listenelemente eingeben lassen, bis der Benutzer beendet
        do
        {
            Console.WriteLine("Neues Listenelement eingeben:");

            // Eingabe der Menge
            Console.Write("Menge: ");
            int menge = ConsoleInput.ReadNextInt();
            output += $"{menge, 6} ";

            // Eingabe der Einheit (z.B. "Stück", "kg", "l")
            Console.Write("Einheit: ");
            string einheit = Console.ReadLine();
            output += $"{einheit, -5}";

            // Eingabe der Bezeichnung (z.B. "Äpfel", "Milch")
            Console.Write("Bezeichnung: ");
            string bezeichnung = Console.ReadLine();
            output += bezeichnung + "\n";

            // Hinzufügen des neuen Elements zur Einkaufsliste

            Console.Write("Möchten Sie ein weiteres Element hinzufügen? (j/n): ");
            addNewItem = ConsoleInput.ReadNextChar();
            numOfItems++;

        } while (addNewItem == 'j');

        Console.Write(output);
        Console.Write(@$"--------------------------
Anzahl der Elemente: {numOfItems}");
    }
} */
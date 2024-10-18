using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;

namespace BerkantAkinci.Week02
{

    class Einkaufsliste
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
                output += $"{menge,6} ";

                // Eingabe der Einheit (z.B. "Stück", "kg", "l")
                Console.Write("Einheit: ");
                string einheit = Console.ReadLine();
                output += $"{einheit,-5}";

                // Eingabe der Bezeichnung (z.B. "Äpfel", "Milch")
                Console.Write("Bezeichnung: ");
                string bezeichnung = Console.ReadLine();
                output += bezeichnung + "\n";

                // Hinzufügen des neuen Elements zur Einkaufsliste

                Console.Write("Möchten Sie ein weiteres Element hinzufügen? (j/n): ");
                addNewItem = ConsoleInput.PrintNextChar();
                numOfItems++;

            } while (addNewItem == 'j');

            Console.Write(output);
            Console.Write($"-------------------------- \nAnzahl der Elemente: {numOfItems}");
        }
    }
}




/*public static void PrintEinkaufsliste()
{
   Abfrage();
}

public static void Abfrage()
{
    string stop = "STOP";
    string art = "";

    while (art != stop)
    {
        System.Console.WriteLine($"Was muss ich noch einkaufen gehen?");
        art = Console.ReadLine();

        System.Console.WriteLine($"\nWie viel {art} brauchst du?");
        int many = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine($"\nEinkaufsliste: \n{many} {art}");

        System.Console.WriteLine($"----------------------- \n{art/*ändern} Elemente auf der Liste\n");

    }
}*/

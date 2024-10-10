using System;
using System.Collections.Generic;

using MarcelSimma.Week02;

class ShoppingList
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
}
using System;

namespace FlorianBaier.Week02
{

    public class Einkaufsliste2
    {

        public static void EinkaufslisteBase()
        {
            string output = "Deine Einkaufsliste lautet: \n\n";
            char addNewItem;
            int numOfItems = 0;


            do{
                Console.WriteLine("Neues Listenelement hinzufügen: ");
                Console.Write("Menge: ");
                int menge = ConsoleInput.ReadNextInt();
                output += $"{menge, 6}";

                Console.Write("Einheit: ");
                string einheit = Console.ReadLine();
                output += $"{einheit, -5}";

                Console.Write("Bezeichnung: ");
                string bezeichnung = Console.ReadLine();
                output+= bezeichnung + "\n";

                Console.Write("Möchten Sie ein weiteres Element hinzufügen? (j/n)");
                addNewItem = ConsoleInput.ReadNextChar();
                numOfItems++;
            }while (addNewItem == 'j');

            Console.Write(output);
            Console.Write(@$"----------------
            Anzahl der Elemente: {numOfItems}");
        }
    }
}
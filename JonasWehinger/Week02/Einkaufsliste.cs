using System;

namespace JonasWehinger.Week02
{
    public class Liste
    {
        public static void Einkaufsliste()
        {

            List<string> einkaufsliste = new List<string>();

         while (true)
            {
            Console.WriteLine("Gib an was du zur Einkaufsliste hinzufügen möchtest(wenn du fertig bist schreib 'Fertig'):");
            string eingabe = Console.ReadLine();

            if(eingabe.ToLower() == "fertig")
            {
                break;
            
            }

             Console.Write("Gib die Menge für " + eingabe + " ein: ");
            string mengeInput = Console.ReadLine();

            
            if (int.TryParse(mengeInput, out int menge))
            {
                einkaufsliste.Add(menge + " " + eingabe);
            }
            else
            {
                Console.WriteLine("Bitte eine gültige Zahl eingeben.");
            }
        }

        
        Console.WriteLine("\nEinkaufsliste:");
        for (int i = 0; i < einkaufsliste.Count; i++)
        {
            Console.WriteLine(einkaufsliste[i]);
        }

        Console.WriteLine("---------------------");
        Console.WriteLine(einkaufsliste.Count + " Elemente auf der Liste");
    }



            }
        }

    

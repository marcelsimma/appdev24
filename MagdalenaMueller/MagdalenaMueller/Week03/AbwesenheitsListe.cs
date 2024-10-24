using System;

namespace MagdalenaMueller.Week03
{
    public class AbwesenheitsListe
    {
        public static void AbwesenheitsListeProgramm()
        {
            bool again = true;
            string[,] persons = new string[6,4]; 

            persons [0,0] = "         ";
            persons [0,1] = "DI";
            persons [0,2] = "MI";
            persons [0,3] = "DO";

            for(int i = 1; i<=5; i++)
            {
                Console.WriteLine("Gib 5 Namen ein");
                string name = Console.ReadLine();
                persons[i,0] = name;
            }

            while(again == true)
            {
                Console.WriteLine("\n1: An/Abwesenheit eintragen \n2: Liste Ansehen\n3: Beenden");
                string input = Console.ReadLine();

                switch(input)
                {
                    case "1":
                        Console.WriteLine("\nTeilnehmer: ");
                        string member = Console.ReadLine();
                        for (int i = 1; i < persons.GetLength(0); i++) 
                        {
                            if (persons[i, 0] == member)
                            {
                                Console.WriteLine("Tag: ");
                                string day = Console.ReadLine();
                                for (int j = 1; j < persons.GetLength(1); j++) 
                                {
                                    if (persons[0, j] == day)
                                    {
                                        Console.WriteLine("Eintrag: ");
                                        string entry = Console.ReadLine();
                                        persons[i, j] = entry;
                                        break;
                                    }
                                }
                
                            }    
                        }  
                        break;  
                    case "2":
                        for (int i = 0; i < persons.GetLength(0); i++)
                        {
                            for (int j = 0; j < persons.GetLength(1); j++)
                            {
                                Console.Write(persons[i, j] + " ");
                            }
                            Console.WriteLine();
                        }
                        break;
                    default:
                        again = false;
                        break;
                }
            }
            
        }
    }
}
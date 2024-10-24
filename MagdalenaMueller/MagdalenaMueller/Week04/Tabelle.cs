using System;
using System.Xml.Serialization;

namespace MagdalenaMueller.Week04
{
    public class Tabelle
    {
        public static void TabelleProgramm()
        {
            String[] firstName = {"Alfonso", "Beatrix-Eleonor", "Cecil", "Daniel", "Elmar"};
            String[] lastName = {"Klein", "Kinderdorfer", "Al Elmenar", "Schmidt", "Simma"};
            int[] age = {40, 78, 5, 18, 81};
            String[] place = {"Wien", "Schwarzach", "Wiener Neudorf", "Sankt Pölten", "Sankt Pölten"};
            float[] distanceFromCapital = {0f, 654.4f, 12.457634366f, 120.0f, 119.9999f};
            

            int logestFirstName = 0;
            int longestLastName = 0;
            int logestAge = 4;
            int logestPlace = 0;
            int logestDistance = 22;

            for(int i = 0; i < firstName.Length -1 ; i++)
            {
                if(firstName[i].Length > logestFirstName)
                {
                    logestFirstName = firstName[i].Length;
                }
            }
            for(int i = 0; i < lastName.Length -1 ; i++)
            {
                if(lastName[i].Length > longestLastName)
                {
                    longestLastName = lastName[i].Length;
                }
            }
            for(int i = 0; i < place.Length -1 ; i++)
            {
                if(place[i].Length > logestPlace)
                {
                    logestPlace = place[i].Length;
                }
            }
            
            string seperate = new string('-', logestFirstName +1) +"|" +
                                new string('-', longestLastName +1) +"|" +
                                new string('-', logestAge +1) + "|" +
                                new string('-',logestPlace +1) + "|" +
                                new string('-', logestDistance +1) + "|";

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("First Name" + new string(' ',logestFirstName- 9) +"|" +
                             "Last Name" + new string(' ',longestLastName - 8) + "|" +
                             "Age" + new string(' ',logestAge - 2) + "|" +
                             "Place" + new string(' ',logestPlace - 4)+ "|" +
                             "Distence From Capital" + new string(' ', logestDistance - 20) + "|");
            
            Console.WriteLine(seperate);
            Console.ResetColor();
            
            for(int i = 0; i <= firstName.Length -1; i++)
            { 
                Console.WriteLine(firstName[i] + new string(' ', logestFirstName - firstName[i].Length +1)+ "|" +
                                lastName[i] + new string(' ', longestLastName - lastName[i]. Length +1)+ "|"+
                                new string(' ', logestAge - age[i].ToString().Length +1) + age[i] + "|" +
                                place[i] + new string(' ', logestPlace - place[i].Length + 1)+ "|" +
                                new string(' ', logestDistance - distanceFromCapital[i].ToString("F2").Length + 1) + distanceFromCapital[i].ToString("F2")  + "|");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(seperate);
                Console.ResetColor();
            }
        }
    } 
}
using System;

namespace LucasSchiemann.Week04;

public static class Tabellensorter
{
    
    public static void Start()
    {

        string[] firstName = {"Alfonso", "Beatrix-Eleonor", "Cecil", "Daniel", "Elmar"};
        string[] lastName = {"Klein", "Kinderdorfer", "Al Elmenar", "Schmidt", "Simma"};
        int[] age = {40, 78, 5, 18, 81};
        string[] place = {"Wien", "Schwarzach", "Wiener Neudorf", "Sankt Pölten", "Sankt Pölten"};
        float[] distanceFromCapital = {0f, 654.4f, 12.457634366f, 120.0f, 119.9999f};
        string[,]informationOfPeople = new string[5,5];
        for(int i = 0;i <= 4; i++)
        {
            
            informationOfPeople[i,0] = firstName[i]; 
            informationOfPeople[i,1] = lastName[i]; 
            informationOfPeople[i,2] = Convert.ToString(age[i]);
            informationOfPeople[i,3] = place[i];
            informationOfPeople[i,4] = Convert.ToString(distanceFromCapital[i]);


        }

        Printer(informationOfPeople);
        //Printer(firstName,lastName,age,place,distanceFromCapital);
    }
    static void Printer(string[,] informationOfPeople)
    {
        for (int j= 0;j < informationOfPeople.Length;j++);
        {
            Console.WriteLine(informationOfPeople);

        }
    }
}

        /*
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("|Vorname: "+ firstname[i]+ "                       |");
            Console.WriteLine("|Nachname: "+ lastName[i]+ "                      |");
            Console.WriteLine("|Alter: "+ age[i]+ "                          |");
            Console.WriteLine("|Wohnort: "+ place[i]+"                         |");
            Console.WriteLine("|Entfernung Von der Hauptstadt: "+ distanceFromCapital[i]+"|");
            Console.WriteLine("----------------------------------------------------");
        }
        */
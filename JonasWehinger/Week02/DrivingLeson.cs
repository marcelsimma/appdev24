using System;

namespace JonasWehinger.Week02
{

    public class Schein
    {

        

        public static void DrivingLeson()
        {

        int counter = 0;
        while( counter < 5)    
        {
            counter ++;
            Console.WriteLine("Wie heißt du?");
            string Name = Console.ReadLine();
            Console.WriteLine("Wie alt bist du?");
            int age = Convert.ToInt32(Console.ReadLine());
            Moped(Name,age);
        }
        
        }
        

            public static void Moped(string Name, int age)
            {
            if ( age > 14)
            {
            
            Console.WriteLine("Du darfst Moped fahren!");
            Auto(Name,age);
            
            }
            else
            {

            Console.WriteLine("Du darfst kein Moped fahren!");
            Auto(Name,age);

            }}

            public static void Auto(string Name, int age)
            {
            if ( age > 18)
            {
            
            Console.WriteLine("Du darfst ein Auto fahren!");
            
            }
            else
            {

            Console.WriteLine("Du darfst kein Auto fahren!");

            }


             }
        }
    }
        
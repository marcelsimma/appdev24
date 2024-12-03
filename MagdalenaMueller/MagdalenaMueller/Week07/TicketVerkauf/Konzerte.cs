using System;
using System.Data;
using System.Diagnostics.Metrics;

namespace MagdalenaMueller.Week07
{
    public class Konzerte
    {
        static Queue<string> Conzert1 = new Queue<string>();
        static Queue<string> Conzert2 = new Queue<string>();
        static Queue<string> Conzert3 = new Queue<string>();


        static List<string> SelledConzert1 = new List<string>();
        static List<string> SelledConzert2 = new List<string>();
        static List<string> SelledConzert3 = new List<string>();

        static int counter1 = 0;
        static int counter2 = 0;
        static int counter3 = 0;

        static int counter = 1;

        public static void Start()
        {
            bool c1 = false;
            bool c2 = false;
            bool c3 = false;

            Konzerte.FillLines();

            while(c1 != true || c2 != true || c3 != true)
            {
                Konzerte.FillLineRandom();
                Konzerte.WriteQueue();
                Thread.Sleep(1000);

                c1 = Konzerte.SellTicketsConzert1();
                c2 = Konzerte.SellTicketsConzert2();
                c3 = Konzerte.SellTicketsConzert3();
                Konzerte.WriteQueue();
                Thread.Sleep(1000);
            }
            //Konzerte.WriteConzertsPeople();
            Konzerte.WriteConzertsTickets();
        }
        public static void FillLines()
        {
            for(int i = 0; i < 10; i++)
            {
                var r = new Random();
                int random = r.Next(1,4);

                if(random == 1)
                {
                    Conzert1.Enqueue("|");                
                }
                else if( random == 2)
                {
                    Conzert2.Enqueue("|");
                }
                else if(random == 3)
                {
                    Conzert3.Enqueue("|");
                }
            }
        }
        public static void FillLineRandom()
        {
            var r = new Random();
            int random = r.Next(1,5);
            int random2 = r.Next(1,5);

            if(random == 1 && random2 == 1) {Conzert1.Enqueue("|");Conzert1.Enqueue("|");counter1+=2;}
            else if(random == 1 || random2 == 1){Conzert1.Enqueue("|");counter1++;} 

            if(random == 2 && random2 == 2) {Conzert2.Enqueue("|");Conzert2.Enqueue("|");counter2+=2;}
            else if(random == 2 || random2 == 2){Conzert2.Enqueue("|");counter2++;}
            
            if(random == 3 && random2 == 3) {Conzert3.Enqueue("|");Conzert3.Enqueue("|");counter3+=2;}
            else if(random == 3 || random2 == 3){Conzert3.Enqueue("|");counter3++;}
        }
        
        public static void WriteQueue()
        {
            Console.Clear();
            Console.Write("Konzert 1: ");
            foreach(var people in Conzert1)
            {
                Console.Write(people);
            }
            Console.WriteLine();

            Console.Write("Konzert 2: ");
            foreach(var people in Conzert2)
            {
                Console.Write(people);
            }
            Console.WriteLine();

            Console.Write("Konzert 3: ");
            foreach(var people in Conzert3)
            {
                Console.Write(people);
            }
            Console.WriteLine();
        }

        public static bool SellTicketsConzert1()
        {
            while(Conzert1.Count > 0)
            {
                SelledConzert1.Add($"Person{counter}");
                Conzert1.Dequeue();
                counter++;
                counter1++;
                if(Conzert1.Count > 0)
                {
                    return false;
                }
            }
            return true;
        }
        public static bool SellTicketsConzert2()
        {
            while(Conzert2.Count >0)
            {
                SelledConzert2.Add($"Person{counter}");
                Conzert2.Dequeue();
                counter++;
                counter2++;
                if(Conzert2.Count >0)
                {
                    return false;
                }
            }
            return true;
        }
        public static bool SellTicketsConzert3()
        {
            while(Conzert3.Count > 0)
            {
                SelledConzert3.Add($"Person{counter}");
                Conzert3.Dequeue();
                counter++;
                counter3++;
                if(Conzert3.Count > 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static void WriteConzertsPeople()
        {
           
            Console.WriteLine("\nKonzert 1: ");

            for(int i = 0; i < SelledConzert1.Count; i++)
            {
                Console.WriteLine(SelledConzert1[i]);
            }
            Console.WriteLine(); 

            Console.WriteLine("Konzert 2: ");
            for(int i = 0; i < SelledConzert2.Count; i++)
            {
                Console.WriteLine(SelledConzert2[i]);
            }
            Console.WriteLine();

            Console.WriteLine("Konzert 3: ");

            for(int i = 0; i < SelledConzert3.Count; i++)
            {
                Console.WriteLine(SelledConzert3[i]);
            }
            Console.WriteLine();
        }
        public static void WriteConzertsTickets()
        {
            Console.WriteLine($"\nKonzert1: {counter1} Tickets\nKonzert2: {counter2} Tickets\nKonzert3: {counter3} Tickets");
        }
   }
}
namespace JonasWehinger.Week04
{
 
    public class TabErmitteln()
    {
        public static void Ermitteln()
    {

        DateTime heute = DateTime.Now;

            Console.WriteLine("Die nächsten drei Sonntage sind:");

            
            for (int sonntagCount = 0; sonntagCount < 3; heute = heute.AddDays(1))
            {
                
                if (heute.DayOfWeek == DayOfWeek.Sunday)
                {
                   
                    Console.WriteLine(heute.ToString("dd.MM.yyyy"));
                    sonntagCount++; 
                }
            }
        }
    }
}
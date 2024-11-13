using System;

namespace JonasWehinger.Week05
{
    
    public class Motorrad
    {
        
        int KMStand;
        bool InDerBewegung = false;
        public Motorrad(int kmStand)
        {
            KMStand = kmStand;
        }
        public void fahre(int kilometer)
        {
            KMStand += kilometer;
            InDerBewegung = true;
            
            Console.WriteLine("Motorrad fährt" + kilometer + " km.");
        }
        public void stop()
        {
            InDerBewegung = false;
        }
        public string Fahren()
        {
            if (InDerBewegung)
            {
                return "ja";
            }
            else
            {
                return "nein";
            }
        }

        public override string ToString()
        {
            return string.Format("{0} km", KMStand);
        }
    }
}
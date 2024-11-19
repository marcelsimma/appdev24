using System;
namespace JulianStroehle.Week7.Callcenter
{
    internal class Callcenter
    {
        static Queue<Call> calls = new Queue<Call>();
        internal static void Start()
        {
            do
            {
                Queue();
                Console.WriteLine("Weiterer Verpasster Anruf? (j/n)");
            }
            while (Console.ReadLine() == "j");
            while (calls.Count > 0)
            {
                CallPerson();
            }
            Console.WriteLine("Alle verpassten Anrufe abgearbeitet.");
        }
        static void Queue()
        {
            Console.WriteLine("Verpasster Anruf. Nummer des Anrufers?");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Name?");
            string name = Console.ReadLine();
            DateTime dt = DateTime.Now;
            Call call = new(number, name, dt);
            calls.Enqueue(call);
        }
        static void CallPerson()
        {
            Console.WriteLine("\nNächste Person:\n" + calls.Dequeue().ToString() + "\n\nPerson wird Angerufen... (Enter um weiterzumachen)");
            Console.ReadLine();
        }
    }
}
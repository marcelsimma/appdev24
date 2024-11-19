using System;

namespace OliverBedogg.Week06
{
    public class QueueExample
    {
        public static void Start()
        {
            Queue<string> numbers = new Queue<string>();

            // Einreihen
            numbers.Enqueue("one");
            numbers.Enqueue("two");
            numbers.Enqueue("three");
            numbers.Enqueue("four");
            numbers.Enqueue("five");

            // Iteration durch Queue-Einträge
            foreach (string number in numbers)
            {
                Console.WriteLine(number);
            }

            // Dequeue: Verarbeite ersten Eintrag (entfernt Eintrag aus Liste)
            Console.WriteLine("\nDequeuing '{0}'", numbers.Dequeue());
            // Peek: Lese ersten Eintrag
            Console.WriteLine("Peek at next item to dequeue: {0}", numbers.Peek());

            Console.WriteLine("Dequeuing '{0}'", numbers.Dequeue());
            Console.WriteLine("------------------");

            Console.WriteLine("'one' existiert in der Queue: {0}", numbers.Contains("one"));
            Console.WriteLine("'five' existiert in der Queue: {0}", numbers.Contains("five"));
            Console.WriteLine("------------------");

            // Entferne Alle Einträge
            numbers.Clear();
        }
    }
}
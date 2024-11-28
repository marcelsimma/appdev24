using System;

namespace BerkantAkinci.AForMe
{
    class QueueLearn
    {
        public static void Start()
        {
            Queue<string> numbers = new Queue<string>();

            numbers.Enqueue("one");
            numbers.Enqueue("two");
            numbers.Enqueue("three");
            numbers.Enqueue("four");
            numbers.Enqueue("five");

            numbers.Dequeue();

            foreach (string number in numbers) {
                System.Console.WriteLine(number);
            }



        }
    }
}
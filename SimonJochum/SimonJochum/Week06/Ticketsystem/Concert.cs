using System;

namespace SimonJochum.Week06.Ticketsystem
{
    public class Concert
    {
        public string Name { get; }
        public Person @Person;
        public Queue<string> BuyingQueue = new Queue<string>();
        public Queue<Person> BuyingQueue2 = new Queue<Person>();
        public Queue<int> BuyingQueue3 = new Queue<int>();

        public Concert(string name)
        {
            Name = name;
        }

        public Concert(Person person)
        {
            @Person = person;
        }
    }
}
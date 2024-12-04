using System;

namespace SimonJochum.Week06.Ticketsystem
{
    public class Person
    {
        public string FullName{get;}
        public Person(string fullName)
        {
            FullName = fullName;
        }

         public override string ToString()
        {
            return FullName;
        }
    }
}
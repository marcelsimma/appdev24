using System;

namespace SimonJochum.Week07.ParticipantList
{
    public class Person
    {       
        public string FullName { get; }
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
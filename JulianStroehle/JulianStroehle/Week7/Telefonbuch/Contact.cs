using System;
namespace JulianStroehle.Week7.Telefonbuch
{
    internal class Contact
    {
        string _firstName;
        string _lastName;
        int _number;
        string _place;
        internal Contact(string firstName, string lastName, int number, string place)
        {
            _firstName = firstName;
            _lastName = lastName;
            _number = number;
            _place = place;
        }
        public override string ToString()
        {
            return string.Format("{0}; {1}; {2}; {3}; ", _firstName, _lastName, _number, _place);
        }
    }
}
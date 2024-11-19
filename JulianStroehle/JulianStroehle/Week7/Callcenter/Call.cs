using System;
namespace JulianStroehle.Week7.Callcenter
{
    internal class Call
    {
        int _number;
        string _name;
        DateTime _dateTime;
        internal Call(int number, string name, DateTime dateTime)
        {
            _number = number;
            _name = name;
            _dateTime = dateTime;
        }
        public override string ToString()
        {
            return string.Format("├──Name: {0}\n├──Nummer: {1}\n└──Datum und Uhrzeit: {2}", _name, _number, _dateTime);
        }
    }
}
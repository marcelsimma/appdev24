using System;

namespace CheyenneHarbarth.Week07.Callcenter
{
    public class CallItem
    {
        public string Fullname;
        public string Phonenumber;
        public DateTime Calltime;


        // Konstruktor
        public CallItem(string fullname, string phonenumber, DateTime callTime)
        {
            Fullname = fullname;
            Phonenumber = phonenumber;
            Calltime = callTime;
        }

        // Herkunft der ToString Methode: https://learn.microsoft.com/de-de/dotnet/api/system.object.tostring?view=net-8.0
        // ToString Methode wird geeerbt und mit override überschreibe ich diese
        public override string ToString()
        {
            return $"Anrufername: {Fullname,-20} | Telefonnummer: {Phonenumber,-20} | Anrufzeit: {Calltime,15}";
        }
    }
}
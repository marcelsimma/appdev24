using System;
using System.Globalization;

namespace MagdalenaMueller.Week07
{
    public class Caller
    {
        public string CallerName;
        public string Telephonenumber;
        DateTime CallTime;

        public Caller(string callerName, string telephonenumber, DateTime callTime)
        {
            CallerName = callerName;
            Telephonenumber = telephonenumber;
            CallTime = callTime;
        }

        public override string ToString()
        {
            return $"Anrufername: {CallerName, -15} Telefonnummer: {Telephonenumber, -15} Anrufzeit: {CallTime, 15}";
        }
    }
}
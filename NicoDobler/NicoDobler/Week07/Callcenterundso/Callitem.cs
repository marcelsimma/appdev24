using System;
namespace NicoDobler.Week07 {

    public class CallItem {

        public string Fullname;

        public string Phonenumber;

        public DateTime CallTime;

            public CallItem(string fullname, string phonenumber, DateTime callTime) {
            Fullname = fullname;
            Phonenumber = phonenumber;
            CallTime = callTime;
        }

        public override string ToString()
        {
            return $"Anrufername: {Fullname, -20} Telefonnummer: {Phonenumber, -15} Anrufzeit: {CallTime, 15}";
        }


    }

}
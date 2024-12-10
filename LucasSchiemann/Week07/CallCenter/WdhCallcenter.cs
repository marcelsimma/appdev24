using System;

public class CallCenterObjekt {

        
        public string WholeName;

        public string Phonenumber;

        public DateTime TimeOfCall;

        
        
        public CallCenterObjekt(string fullname, string phonenumber, DateTime callTime) {
            WholeName = fullname;
            Phonenumber = phonenumber;
            TimeOfCall = callTime;
        }
        public override string ToString()
        {
            return $"Anrufername: {WholeName, -20} Telefonnummer: {Phonenumber, -15} Anrufzeit: {TimeOfCall, 15}";
        }


    }
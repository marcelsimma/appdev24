using System;


namespace MarcelSimma.Week06.FotoapparatObjektivSpeicherkarte {


    public class Hardware {

        public required string Seriennummer { get; init; }

        public Hardware(string seriennummer) {
            Seriennummer = seriennummer;
        }

    }
}
using System;

namespace MarcelSimma.Week07.ContactList {

    public class ContactItem {

        public string Firstname;
        public string Lastname;
        public string Phonenumber;
        public string City;

        public ContactItem(string firstname, string lastname, string phonenumber, string city) {
            Firstname = firstname;
            Lastname = lastname;
            Phonenumber = phonenumber;
            City = city;
        }

        // ToString wird vererbt. Um eine vererbte Methode zu überschreiben, brauchen wir das Keyword override
        // static: Klassenmethode
        // non static: Instanzmethode - Methode dem Objekt bzw. den Objekten zugeordnet
        public override string ToString() {
            return $"{Firstname, 10} {Lastname, 10} {Phonenumber, 15} {City, 10}";
            //return base.ToString();
        }

        // Klassenmethode
        public static ContactItem ReadContactItemFromConsole() {
            
            // Werte von der Console einlesen
            string completeName = Console.ReadLine(); // Beispiel Input: "Barbara Marte"
            string[] splittedName = completeName.Split(" ");
            
            string phonenumber = Console.ReadLine();
            string city = Console.ReadLine();

            return new ContactItem(splittedName[0], splittedName[1], phonenumber, city);
        }


    }

}
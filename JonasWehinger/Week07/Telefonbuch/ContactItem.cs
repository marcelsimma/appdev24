using System;

namespace JonasWehinger.Week07.ContactItem
{

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

        public override string ToString() {
            return $"{Firstname, 10} {Lastname, 10} {Phonenumber, 15} {City, 10}";
        }

        public static ContactItem ReadContactItemFromConsole() {
            
            
            string FullName = Console.ReadLine(); 
            string[] splittedName = FullName.Split(" ");
            
            string phonenumber = Console.ReadLine();
            string city = Console.ReadLine();

            return new ContactItem(splittedName[0], splittedName[1], phonenumber, city);
        }
    }
}
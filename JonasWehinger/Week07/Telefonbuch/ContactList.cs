using System;

namespace JonasWehinger.Week07.ContactItem
{

    public class ContactList 
    {

        public static void Start()
        {

            List<ContactItem> contactList = new List<ContactItem>(18);

            foreach (ContactItem item in contactList) {
                System.Console.WriteLine(item.ToString());
            }
        }
    }
} 
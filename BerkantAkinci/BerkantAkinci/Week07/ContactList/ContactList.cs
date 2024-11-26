using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace BerkantAkinci.Week07.ContactList
{
    public class ContactList
    {
        // static: KLassenmethode
        // non static: Instanzmethode
        public static void Start()
        {
            List<ContactItem> contactList = new List<ContactItem>(18);

            // 1 Schritt Objekt erstellen und in die Liste einfügen
            contactList.Add(new ContactItem("Barbara", "Marte", "+43....", "Bregenz"));
            contactList.Add(new ContactItem("Barbara", "Marte", "+43....", "Bregenz"));
            contactList.Add(new ContactItem("Barbara", "Marte", "+43....", "Bregenz"));
            contactList.Add(new ContactItem("Barbara", "Marte", "+43....", "Bregenz"));
            contactList.Add(new ContactItem("Barbara", "Marte", "+43....", "Bregenz")); //index 4
            contactList.Add(new ContactItem("Barbara", "Marte", "+43....", "Bregenz"));
            contactList.Add(new ContactItem("Barbara", "Marte", "+43....", "Bregenz"));
            contactList.Add(new ContactItem("Barbara", "Marte", "+43....", "Bregenz"));
            contactList.Add(new ContactItem("Barbara", "Marte", "+43....", "Bregenz"));
            contactList.Add(new ContactItem("Barbara", "Marte", "+43....", "Bregenz"));
            // contactList.Insert(10, new ...)
            contactList.Add(new ContactItem("Barbara", "Marte", "+43....", "Bregenz"));
            contactList.Add(new ContactItem("Barbara", "Marte", "+43....", "Bregenz"));
            contactList.Add(new ContactItem("Barbara", "Marte", "+43....", "Bregenz"));
            contactList.Add(new ContactItem("Barbara", "Marte", "+43....", "Bregenz"));
            contactList.Add(new ContactItem("Barbara", "Marte", "+43....", "Bregenz"));
            contactList.Add(new ContactItem("Barbara", "Marte", "+43....", "Bregenz"));
            contactList.Add(new ContactItem("Barbara", "Marte", "+43....", "Bregenz"));
            contactList.Add(new ContactItem("Barbara", "Marte", "+43....", "Bregenz"));
            contactList.Add(new ContactItem("Barbara", "Marte", "+43....", "Bregenz"));
            contactList.Add(new ContactItem("Barbara", "Marte", "+43....", "Bregenz"));
            //contactList.Add(ContactItem.ReadContactItemFromConsole());

            System.Console.WriteLine();

            // 2 Schritte Objekt erstellen und Liste einfügen
            // 1. Schritt
            ContactItem contact1 = new ContactItem("Berkant", "Marte", "+43....", "Bregenz");
            ContactItem contact2 = new ContactItem("brtk", "Marte", "+43....", "Bregenz");
            ContactItem contact3 = new ContactItem("dgdgdg", "Marte", "+43....", "Bregenz");
            ContactItem contact4 = new ContactItem("dgdbvd", "Marte", "+43....", "Bregenz");
            ContactItem contact5 = new ContactItem("vdfdfv", "Marte", "+43....", "Bregenz");
            ContactItem contact6 = new ContactItem("dfgfgd", "Marte", "+43....", "Bregenz");
            ContactItem contact7 = new ContactItem("vdvdvdfv", "Marte", "+43....", "Bregenz");

            // 2. Schritt
            contactList.Add(contact1);

            // Element zwischen vorhandenen Elementen einfügen
            // contactList.Insert();

            // Anzahl der Listenelemente die schon in der Liste sind
            System.Console.WriteLine(contactList.Count);

            // momentan verfügbare Kapazität >= contactList.Count
            System.Console.WriteLine(contactList.Capacity);


            // alle Kontakte auf der Console ausgeben
            foreach (ContactItem item in contactList)
            {
                System.Console.WriteLine(item.ToString());
            }

            System.Console.WriteLine();

            // Kontakt basierend auf Index auf der Console ausgeben
            Console.WriteLine(contactList[4]);
            // Console.WriteLine führt immer automatisch die .ToString() methode für jede Variable aus. 
        }
    }
}
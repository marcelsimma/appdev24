using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace MarcelSimma.Week07.ContactList {

    public class ContactList {

        // static: KLassenmethode
        // non static: Instanzmethode
        public static void Start() {

            List<ContactItem> contactList = new List<ContactItem>(18);
            

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
            
            // Element von der Console einlesen und hinten zur Liste hinzufügen
            //contactList.Add(ContactItem.ReadContactItemFromConsole());
            
            // Element zwischen vorhandenen Elementen einfügen
            // contactList.Insert();

            // Anzahl der Listenelemente die schon in der Liste sind
            System.Console.WriteLine(contactList.Count);

            // momentan verfügbare Kapazität >= contactList.Count
            System.Console.WriteLine(contactList.Capacity);
            

            // alle Kontakte auf der Console ausgeben
            foreach (ContactItem item in contactList) {
                System.Console.WriteLine(item.ToString());
            }

            System.Console.WriteLine();

            // Kontakt basierend auf Index auf der Console ausgeben
            Console.WriteLine(contactList[4]);
            // Console.WriteLine führt immer automatisch die .ToString() methode für jede Variable aus. 

            System.Console.WriteLine(contactList.Find(item => item.Firstname == "Marcel"));

            

            
            
            
        }

        


    }

}
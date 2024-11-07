using System;

namespace AlessioGaudio.Week04
{
    public class Contacts
    {
        private string[] names = new string[5];
        private string[] phoneNumbers = new string[5];
        private int count = 0;


        public void AddContact(string name, string phoneNumber)
        {
            if (count < 5)
            {
                names[count] = name;
                phoneNumbers[count] = phoneNumber;
                count++;
            }
        }
    }
}
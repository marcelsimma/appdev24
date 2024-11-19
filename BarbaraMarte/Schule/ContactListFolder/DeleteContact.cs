namespace BarbaraMarte.Schule.ContactsListFolder;

class DeleteContact : ContactsNewList
{
    public static void DeleteContacts()
    {
        Console.WriteLine("Which contact are you looking for?");
        string? input = Console.ReadLine();
        bool contactFound = false;

        for (int i = 0; i < firstName.Count; i++)
        {
            if (firstName[i] == input)
            {
                Console.WriteLine("{0} is now removed from your list", firstName[i]);
                firstName.RemoveAt(i);
                lastName.RemoveAt(i);       // .RemoveAt(i) removes the input ( the contact information ) at the position i
                phoneNumber.RemoveAt(i);
                contactFound = true;
                break;
            }
        }
        if (!contactFound)
        {
            Console.WriteLine($"The name you entered is not in your contact list.");
        }
        Start();
    }
}
namespace BarbaraMarte.Schule.ContactsListFolder;

class SearchContact : ContactsNewList
{
    public static string SearchInList()     //  use a string instead a void that I can use a return in the if part. Makes it easier to return value
    {
        string? input = Console.ReadLine();
        List<string> foundContacts = new List<string>();
        for (int i = 0; i < firstName.Count; i++)
        {
            if (firstName[i] == input)
            {
                foundContacts.Add($"{firstName[i]} {lastName[i]} - Phone number: {phoneNumber[i]}, Category: {category}");
            }
            else if (lastName[i] == input)
            {
                foundContacts.Add($"{firstName[i]} {lastName[i]} - Phone number: {phoneNumber[i]}, Category: {category}");
            }
            else if (phoneNumber[i] == input)
            {
                foundContacts.Add($"{firstName[i]} {lastName[i]} - Phone number: {phoneNumber[i]}, Category: {category}");
            }
            else if (category[i] == input)
            {
                foundContacts.Add($"{firstName[i]} {lastName[i]} - Phone number: {phoneNumber[i]}, Category: {category}");
            }
        }
        if (foundContacts.Count == 0)
        {
            return "The contact detail you entered is not in your contact list.";
        }
        Console.WriteLine("Found contacts:");
        foreach (var contact in foundContacts)
        {
            Console.WriteLine(contact);
        }
        return "";
    }
}
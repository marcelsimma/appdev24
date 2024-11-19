namespace BarbaraMarte.Schule.ContactsListFolder;

class PrintOutContacts : ContactListFolder
{
    public static void PrintContacts()
    {

        for (int i = 0; i < firstName.Count; i++)
        {
            Console.WriteLine($"First name: {firstName[i]}, family name: {lastName[i]}, phone number: {phoneNumber[i]}");
        }

        lastName.Sort();
        for (int x = 0; x < lastName.Count; x++)
        {
            Console.WriteLine($"Family name: {lastName[x],-10} First Name {firstName[x],-12} Phone number {phoneNumber[x],-15} ");
        }
    }
}
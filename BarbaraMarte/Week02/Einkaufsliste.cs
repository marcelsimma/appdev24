namespace BarbaraMarte.Week02;

class Einkaufliste
{
    public static void PrintEinkaufsliste()
    {
        // List for saving the Shoppinglist
        string output = "Your Shoppinglist is: \n\n";
        char addNewItem;
        int numOfItems = 0;

        //Listelements runs as long as the user presses y
        do
        {
            Console.WriteLine("Enter a new iteme");

            // amount of the itemes
            Console.Write("Amount: ");
            int amount = ConsoleInput.ReadNextInt();
            output += $"{amount,6}";        /* the number is for the indentation (Einrückung).
            If you Write a positive number then the PC writes from Right to Left and fills up the front with spaces.
            The Minus starts writing from the lift side and fills up on the right side.

             the "output +=" is the short writing from:
            output = output + 5  */

            // unit: Stk, kg, l,...
            Console.Write("Unit: ");
            string unit = Console.ReadLine();
            output += $"{unit,-5}";

            // name from the product
            Console.Write("Product Name: ");
            string product = Console.ReadLine();
            output += product + "\n";

            // edding a new element on the Shoppinglist

            Console.Write("Dou you want to adde one more item? (j/n)");
            addNewItem = ConsoleInput.ReadNextChar();
            numOfItems++;

        } while (addNewItem == 'j');

        Console.Write(output);
        Console.Write(@$" -----------------------------
        Amount of the elements: {numOfItems}");
    }
}

/*
        while (true)
        {
            string number = Console.ReadLine(); 
            double.TryParse(amount, out double amount);          

            Console.Write(amount);

            char.TryParse(number, out iteme);
            Console.WriteLine(iteme);

        }
        */
namespace BarbaraMarte.Week07.Supermarket;

class StartSupermarket
{
    public static void Print()
    {
        Product product = new Product("Pizza", "PM123", 3.55, 12, true, false);
        Console.WriteLine(product);

        Register register = new Register();
        List<Register> register2 = new List<Register>();
        register2.Add(register);
        Supermarket supermarket = new Supermarket(1200, 100, true, register2);

        Workers workers = new Workers("Barbara", 7.15, 16.00, 0.0, true, false);
        Console.WriteLine(workers);


    }
}

using System;
using System.Text;

namespace JulianStroehle.Week7.Supermarket
{
    internal class SupermarketMain
    {
        internal static void Start()
        {
            Console.OutputEncoding = Encoding.UTF8;
            DateTime expDate = new DateTime(2025, 12, 31);
            Product product1 = new Product("Apple", 0, expDate, 0.5, false, 0);
            Product product2 = new Product("RedBull", 2, expDate, 1.6, false, 0);
            Product product3 = new Product("Vacuum Cleaner", 0, expDate, 500.40, false, 0);
            List<Product> products = [product1, product2, product3];
            ShoppingCart shoppingCart = new ShoppingCart();
            Customer customer = new Customer(shoppingCart, 0);
            List<Customer> customers = [customer];
            Register register1 = new Register(1);
            Register register2 = new Register(2);
            Register register3 = new Register(3);
            List<Register> registers = [register1, register2, register3];
            Supermarket supermarket = new Supermarket("Sutterlüty", products, registers, customers);
            supermarket.OpenMarket();
            Console.Write("\nYou stumble into a " + supermarket.Name + ", in there ");
            while (supermarket.Open == true)
            {
                Product choose = null;
                int count = 0;
                Console.WriteLine("you see apples, RedBull cans and vacuum cleaners. What do you take and how much? (Press enter in between)");
                string item = Console.ReadLine();
                switch (item.Substring(0, item.Length-1).ToLower())
                {
                    case "apple": choose = product1; break;
                    case "redbull": choose = product2; break;
                    case "vacuum cleaner": choose = product3; break;
                    default: Console.WriteLine("Error"); break;
                }
                int count2 = int.Parse(Console.ReadLine());
                for (int i = 0; i < count2; i++)
                {
                    if (choose != null)
                    {
                        shoppingCart.AddToCart(choose);
                        count++;
                    }
                }
                Console.WriteLine("you put " + count + " " + choose.Name + "s in your cart.\nTotal products in your cart: " + shoppingCart.GetProductCount() + "\n\nGo to the next Register or remove something out of your cart? (y/r)");
                switch (Console.ReadLine())
                {
                    case "y": Console.WriteLine("The value of all products in your Cart equals: " + shoppingCart.GetPrice()); register1.BuyProducts(shoppingCart); break;
                    case "r": Console.WriteLine("What do you want to remove?"); shoppingCart.RemoveFromCart(Console.ReadLine()); break;
                    default: break;
                }
                if (shoppingCart.GetProductCount() == 0)
                {
                    supermarket.CloseMarket();
                }
                else
                {
                    Console.Write("\nYou go back to the start again and ");
                }
            }
            Console.WriteLine("The " + supermarket.Name + " just closed, come back tomorrow.");
        }
    }
}
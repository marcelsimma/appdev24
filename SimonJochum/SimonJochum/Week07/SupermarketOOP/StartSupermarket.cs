using System;

namespace SimonJochum.Week07.SupermarketOOP
{
    public class StartSupermarket
    {
        public static void Start()
        {
            Supermarket Spar = new Supermarket("Spar");
            Product RedBull = new Product("Red Bull", 1.59, 24);
            Product Apple = new Product ("Apfel 'Granny Smith'", 0.40, 60);
            Product Coffee = new Product("Kaffee 'Cappucino", 0.99, 12);
            Product Pear = new Product("Christa", 0.56, 60);
            Product Bread = new Product("Semmel", 0.40, 12);
            Checkout Checkout1 = new Checkout();
            Staff Simon = new Staff("Simon", "SIJO.1302");
            ShoppingCart Cart1 = new ShoppingCart();
            ShoppingCart Cart2 = new ShoppingCart();
            ShoppingCart Cart3 = new ShoppingCart();
            ShoppingCart Cart4 = new ShoppingCart();
            ShoppingCart Cart5 = new ShoppingCart();
            Costumer Caro = new Costumer(0.0, true, Cart1, true);
            Spar.AddProductToInventory(RedBull);
            Spar.AddProductToInventory(Apple);
            Spar.AddProductToInventory(Coffee);
            Spar.AddProductToInventory(Pear);
            Spar.AddProductToInventory(Bread);
            Spar.StaffWhoIsWorking(Simon);

            Spar.OpenMarket();
            Simon.StartWork();
            Simon.WorkAtCheckout();
            Spar.OpenCheckout(Checkout1);
            Cart1.AddProduct(RedBull);
            Cart1.AddProduct(RedBull);
            Cart1.AddProduct(RedBull);
            Cart1.AddProduct(RedBull);
            Cart1.AddProduct(Coffee);
            Cart1.AddProduct(Coffee);
            Cart1.AddProduct(Coffee);
            Console.WriteLine(Cart1.AmountProductsInCart());
            Console.WriteLine(Cart1.CalculateCartPrice());

        }

        
    }
}
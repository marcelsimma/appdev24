using System;
using System.Reflection.Metadata.Ecma335;
using Microsoft.VisualBasic;

namespace LucasSchiemann.Week07.SuperMarkt;

public class SuperMarktStarter
{
    public void Start()
    {

        
        Store Sutti  = new Store("Sutti","Discounter",true);

        Product Bannana = new Product("bannane","87617056",1.99,TypeOfProduct.FreshFood,25);
        Sutti.AddProduct(Bannana);
        Sutti.DisplayProduct(Bannana);
        
        //Product Pinapple = new Product("Annanas","8761056",3.99,TypeOfProduct.FreshFood,14);
        //Store.AddProduct(Pinapple);
        //Product.ToString();
        
        //Store.AddProdukt(Bannana);
        //Store.ListAllProducts();
        

    }
}
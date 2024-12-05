using System;

namespace LucasSchiemann.Week07.SuperMarkt;
public class Product
{
    public string NameOfItem;
    public string ItemNumber;
    public double Price;
    public TypeOfProduct TypeOfProduct;
    public int AmountOfProduktsAV;
    

    /*
    private static string nameOfItem;
    private static string itemNumber;
    private static double price;
    private static TypeOfProduct typeOfProducts;
    private static int amountOfProduktsAV;*/
    public Product(string nameOfItem,string itemNumber,double price,TypeOfProduct typeOfProduct,int amountOfProduktsAV)
    {
        NameOfItem = nameOfItem;
        ItemNumber = itemNumber;
        Price = price;
        TypeOfProduct = typeOfProduct;
        AmountOfProduktsAV=amountOfProduktsAV;

    }

    public override string ToString()
    {
        return $"ItemName: {NameOfItem} ItemNumber: {ItemNumber} + Price: {Price} Type of Product: {TypeOfProduct}";
    }


    /* 
    public static void AddNewProduct()
    {
        Products.Add(NameOfItem);
        Products.Add(ItemNumber);
        Products.Add(Convert.ToString(Price));
        Products.Add(Convert.ToString(TypeOfProducts));
        Products.Add(Convert.ToString(AmountOfProduktsAV));
    }
    public static void WriteProduct()
    {
        System.Console.WriteLine("NameOfItem | ItemNumber | Price   | TypeOfProduct | Products Avialable|");
        foreach(var productInfo in Products)
        {
            System.Console.Write(productInfo+"    |" );
            System.Console.WriteLine("\n");   
            break;
        }
        

    }
    */

}

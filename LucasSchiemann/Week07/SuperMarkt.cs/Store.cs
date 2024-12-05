using System;

namespace LucasSchiemann.Week07.SuperMarkt;
public class Store
{
    public string NameOfStore;
    public string TypeOfStore;
    public bool IsOpen;
    /*
    private string nameOfStore;
    private string typeOfStore;
    private bool isOpen;
    */
    List<Product>Products = new List<Product>();
    List<Kasse>CashRegisters = new List<Kasse>();

    public Store(string nameOfStore,string typeOfStore,bool isOpen)
    {
        NameOfStore = nameOfStore;
        TypeOfStore = typeOfStore;
        IsOpen = isOpen;
    }
    
    public void AddProduct(Product ProductToAdd)
    {
        Products.Add(ProductToAdd);
    }
    
    public void AddRegisters(Kasse RegisterToAdd)
    {
        CashRegisters.Add(RegisterToAdd);
    }
    
    //var product = Products.FirstOrDefault(p => p.ItemNumber == ItemNumber);
    public void DisplayProduct(Product ItemNumber)
    {
        foreach(var product in Products )
            if(product == ItemNumber)
            {
                System.Console.WriteLine(product);
            }
        


    }

    public void ListAllProducts()
    {
        foreach(var product in Products )
        {
           
            System.Console.WriteLine(product);
        }

    }
    
}

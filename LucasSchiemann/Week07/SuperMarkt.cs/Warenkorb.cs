using System;

namespace LucasSchiemann.Week07.SuperMarkt;

public class ShoppingCart
{
    List<Product> ItemsInShoppingKart = new List<Product>();


    
    public void AddItemtoCart(Product ItemToAddInCart)
    {
            ItemsInShoppingKart.Add(ItemToAddInCart);
            

    }

}
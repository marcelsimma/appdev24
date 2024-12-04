using System;

namespace SimonJochum.Week07.SupermarketOOP
{
    public class ProductCategory
    {
        List<ProductCategory> ProductCategories;
        int amountTaxesPerCategory;

        int GetTaxes()
        {
            return amountTaxesPerCategory;
        }
    }
}
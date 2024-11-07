using System;

namespace BarbaraMarte.Week05
{

    class ArrayWiederholung
    {
        public static void Print()
        {
            string[] article = { "butter", "flower", "milk", "sugar", "chips", "bread", "zucchini", "onion", "garlic", "pumpkin" };
            string[] newArticle = { "yoghurt", "paper", "pen", "cat food", "sausage" };
            string[] totalArticles = { };

            foreach (string a in article)
            {
                Console.WriteLine(a);
            }
            for (int i = 0; i < article.Length; i++)
            {
                Console.WriteLine(article[i]);
            }
            totalArticles = [article.Length +];
            Console.WriteLine(newArticle);
        }
    }
}
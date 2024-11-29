using System;

namespace MagdalenaMueller.Week07
{
    public class Produkte
    {
        public static Dictionary<string, double> produkts = new Dictionary<string, double>();

        public static Dictionary<string, double> ProdukteList()
        {
            produkts.Clear();

            produkts.Add("Apfel", 1.55);
            produkts.Add("Banane", 0.99);
            produkts.Add("Birne", 1.25);
            produkts.Add("Karotten", 0.89);
            produkts.Add("Kartoffeln", 2.10);
            produkts.Add("Tomaten", 1.49);
            produkts.Add("Zwiebeln", 0.79);
            produkts.Add("Gurke", 1.09);
            produkts.Add("Paprika", 1.69);
            produkts.Add("Kürbis", 3.00);
            produkts.Add("Kohl", 1.89);
            produkts.Add("Salat", 2.50);
            produkts.Add("Brokkoli", 1.99);
            produkts.Add("Blumenkohl", 2.20);
            produkts.Add("Spinat", 1.30);
            produkts.Add("Brot", 2.49);
            produkts.Add("Milch", 1.29);
            produkts.Add("Käse", 3.49);
            produkts.Add("Butter", 1.99);
            produkts.Add("Joghurt", 0.89);
            produkts.Add("Schinken", 2.99);
            produkts.Add("Wurst", 2.49);
            produkts.Add("Hähnchenbrust", 5.99);
            produkts.Add("Rindfleisch", 7.50);
            produkts.Add("Lachs", 8.99);
            produkts.Add("Eier", 2.89);
            produkts.Add("Mehl", 1.49);
            produkts.Add("Zucker", 1.09);
            produkts.Add("Salz", 0.99);
            produkts.Add("Reis", 2.49);
            produkts.Add("Pasta", 1.29);
            produkts.Add("Kaffee", 4.99);
            produkts.Add("Tee", 2.69);
            produkts.Add("Kakao", 2.99);
            produkts.Add("Saft", 1.79);
            produkts.Add("Cola", 1.49);
            produkts.Add("Wasser", 0.39);
            produkts.Add("Apfelsaft", 1.29);
            produkts.Add("Limonade", 1.99);
            produkts.Add("Schokolade", 1.99);
            produkts.Add("Bonbons", 2.00);
            produkts.Add("Kekse", 1.89);
            produkts.Add("Tütensuppe", 0.99);
            produkts.Add("Pudding", 1.29);
            produkts.Add("Eis", 3.49);
            produkts.Add("Kuchen", 4.99);
            produkts.Add("Chips", 1.79);
            produkts.Add("Nüsse", 2.50);
            produkts.Add("Fruchtgummi", 1.69);
            produkts.Add("Ketchup", 1.99);
            produkts.Add("Senf", 1.19);

            return produkts;
        }
    }
}
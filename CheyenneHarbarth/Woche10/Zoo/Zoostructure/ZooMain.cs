using System;
using CheyenneHarbarth.Zoo.Zoostructure.Animals;
using CheyenneHarbarth.Zoo.Zoostructure.Foods;

namespace CheyenneHarbarth.Zoo.Zoostructure
{
    public class ZooMain
    {
        public static void Start()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Zoo MyZoo = new Zoo("Mühlebacher Streichelzoo", 1964);

            Enclosure AlpineMeadow = new Enclosure("Alpenwiese: neutral, offen und hügelig");
            Enclosure Icelake = new Enclosure("Eissee: sehr kalt");
            Enclosure Marsh = new Enclosure("Ried: kalt, matschig");
            Enclosure Forest = new Enclosure("Nadelwald: kalt, dicht bewaldet");
            Enclosure Jungle = new Enclosure("Urwald: warm, dicht bewachsen");

            MyZoo.AddEnclosure(AlpineMeadow);
            MyZoo.AddEnclosure(Icelake);
            MyZoo.AddEnclosure(Marsh);
            MyZoo.AddEnclosure(Forest);
            MyZoo.AddEnclosure(Jungle);

            Food hay = new Food("Heu (2.Schnitt)", "kg", 0.25);
            Food water = new Food("Wasser", "L", 0.18);
            Food straw = new Food("Stroh", "kg", 0.15);
            Food meat = new Food("Rohfleisch", "kg", 4.79);
            Food seeds = new Food("Körner", "kg", 2.99);
            Food fish = new Food("Makrele", "kg", 19.99);

            Animal animal1 = new Animal("Betty", "Hochlandrind", hay, 10);
            Animal animal2 = new Animal("Boo", "Hochlandrind", hay, 12);
            Animal animal3 = new Animal("Pengi", "Kaiserpinguin", fish, 9);
            Animal animal4 = new Animal("Woddle", "Zwergpinguin", fish, 5);
            Animal animal5 = new Animal("Tigris", "Königstiger", meat, 15);
            Animal animal6 = new Animal("Stripy", "Königstiger", meat, 13);

            animal1.AddFood(water, 50);
            animal2.AddFood(water, 56);
            animal4.AddFood(water, 34);
            animal5.AddFood(water, 42);
            animal2.AddFood(straw, 5);

            AlpineMeadow.AddAnimal(animal1);
            AlpineMeadow.AddAnimal(animal2);
            Icelake.AddAnimal(animal3);
            Icelake.AddAnimal(animal4);
            Jungle.AddAnimal(animal5);
            Jungle.AddAnimal(animal6);

            MyZoo.PrintZoo();

            MyZoo.CalculateFoodConsumption();
            MyZoo.CalculateFoodBill(MyZoo.FoodConsumption);
        }
    }
}
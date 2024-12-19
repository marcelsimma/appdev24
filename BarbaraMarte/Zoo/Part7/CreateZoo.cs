using BarbaraMarte.Zoo.Part1;
using MySql.Data.MySqlClient;

namespace BarbaraMarte.Zoo.Part7
{

    public class CreateZoo
    {
        private static ZooInfo zoo;
        public static void CreateDatabase(string databaseConnectionString)
        {
            string query = @"
-- Create Database 
CREATE DATABASE IF NOT EXISTS Zoo
USE Zoo

-- Create Zoo Table
CREATE TABLE IF NOT EXISTS Zoo (
Zoo_ID INT AUTO_INCREMENT, 
Name_of_Zoo VARCHAR (40), 
Opening_Day DATE, 
Amount_of_food_per_Day DOUBLE(10,2), 
PRIMARY KEY(Zoo_Id));

CREATE TABLE IF NOT EXISTS Enclosure(
Enclosure_ID INT AUTO_INCREMENT,
Enclosure_Type VARCHAR (30), 
Enclosure_Name VARCHAR (30),  
PRIMARY KEY (Enclosure_ID)); -- added zoo_id

CREATE TABLE IF NOT EXISTS ZooKeeper (
Keeper_ID INT AUTO_INCREMENT, 
Keeper_Firs_Name VARCHAR (20), 
Keeper_Last_Name VARCHAR (20), 
PRIMARY KEY (Keeper_ID));  -- added zoo_id

CREATE TABLE IF NOT EXISTS Animal (
Animal_ID INT AUTO_INCREMENT, 
Animal_Species VARCHAR (30), 
Animal_Name VARCHAR (30), 
PRIMARY KEY (Animal_ID)); -- added enclosure_id

CREATE TABLE IF NOT EXISTS Animal_Food(
Animal_Food_ID INT AUTO_INCREMENT, 
Food_Name VARCHAR (30), 
Food_Price DOUBLE (10,2), 
Unit VARCHAR (10), 
PRIMARY KEY (Food_ID));

-- zoo_id, name_of_zoo, opening_day, amount_of_food_per_day
-- Add Connections

-- Zookeeper and Enclosure
CREATE TABLE IF NOT EXISTS keeper_enclosure(
Task_ID INT PRIMARY KEY AUTO_INCREMENT, 
Keeper_ID INT, 
Enclosure_ID INT, 
FOREIGN KEY (Keeper_ID) REFERENCES zookeeper(Keeper_ID), 
FOREIGN KEY (Enclosure_ID) REFERENCES enclosure(Enclosure_ID)); 

-- Animal Food and Animal
CREATE TABLE IF NOT EXISTS Food(
Food_ID INT AUTO_INCREMENT, 
Animal_ID INT, 
Animal_Food_ID INT, 
PRIMARY KEY (Food_ID), 
FOREIGN KEY (Animal_ID) REFERENCES Animal(Animal_ID), 
FOREIGN KEY (Animal_Food_ID) REFERENCES Animal_Food(Animal_Food_ID));
            ";

            using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))
            {
                try
                {
                    connection.Open();

                    MySqlCommand cmd = new(query, connection);
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        /*
        public static void FilDatabase(string databaseConnectionString, string query)
        {
            for (int i = 0; i < 7; i++)
            {
                string table = "";
                switch (i)
                {
                    case 0: table = "zoo"; break;
                    case 1: table = "enclosure"; break;
                    case 2: table = "animal"; break;
                    case 3: table = "food"; break;
                    case 4: table = "zookeeper"; break;
                    case 5: table = "works_in"; break;
                    case 6: table = "eats"; break;
                }
                query = $"SELECT * FROM {table};";
                MySqlCommand cmnd = new(query, connection);
                MySqlDataReader rdr = cmnd.ExecuteReader();
                while (rdr.Read())
                {
                    switch (table)
                    {
                        case "zoo": zoo = new ZooInfo(rdr.GetString("Name_of_Zoo"), DateTime.Now); break;
                        case "enclosure": Enclosure enclosure = new Enclosure(rdr.GetString("Enclosure_Name"), rdr.GetInt32("Enclosure_ID")); zoo._EnclosureList.Add(enclosure); break;
                        case "animal": Animal animal = new Animal(rdr.GetString("Name"), rdr.GetString("Type"), rdr.GetInt32("AnimalID")); zoo._EnclosureList[rdr.GetInt32("EnclosureID") - 1].AddAnimal(animal); break;
                        case "food": AnimalFood food = new AnimalFood(rdr.GetString("Name"), rdr.GetString("Unit"), rdr.GetInt32("Amount"), rdr.GetDouble("Price")); zoo._Food.Add(food); break;
                        case "zookeeper": Zookeeper keeper = new Zookeeper(rdr.GetInt32("ZookeeperID"), rdr.GetString("Name"), rdr.GetString("LastName")); zoo._ZookeeperList.Add(keeper); break;
                        case "works_in": zoo._ZookeeperList[rdr.GetInt32("ZookeeperID") - 1]._EnclosureList.Add(zoo._EnclosureList[rdr.GetInt32("EnclosureID") - 1]); break;
                        case "eats":; zoo._EnclosureList[rdr.GetInt32("EnclosureID") - 1]._AnimalList[rdr.GetInt32("AnimalID") - 1]._AnimalFood.Add(zoo._Food[rdr.GetInt32("FoodNr") - 1], zoo._Food[rdr.GetInt32("FoodNr") - 1]._AmountOfFood); break;
                    }
                }
                StartSimulation();
            }
        }
        */
    }
}
-- Create Database 
CREATE DATABASE Zoo
USE Zoo

-- Create Zoo Table
CREATE TABLE IF NOT EXISTS Zoo (Zoo_ID INT AUTO_INCREMENT, Name_of_Zoo VARCHAR (40), Opening_Day DATE, Amount_of_food_per_Day DOUBLE(10,2), PRIMARY KEY(Zoo_Id));
CREATE TABLE IF NOT EXISTS Enclosure (Enclosure_Type VARCHAR (30), Enclosure_Name VARCHAR (30), Enclosure_ID INT, PRIMARY KEY (Enclosure_ID));
CREATE TABLE IF NOT EXISTS ZooWorker (Keeper_ID INT, Keeper_Firs_Name VARCHAR (20), Keeper_Last_Name VARCHAR (20), PRIMARY KEY (Keeper_ID));
CREATE TABLE IF NOT EXISTS Animal (Animal_ID INT, Animal_Species VARCHAR (30), Animal_Name VARCHAR (30), PRIMARY KEY (Animal_ID)); 
CREATE TABLE IF NOT EXISTS AnimalFood (Animal_Food_ID INT, Food_Name VARCHAR (30), Food_Price DOUBLE (10,2), Unit VARCHAR (10), PRIMARY KEY (Food_ID));


-- Add Connections
CREATE TABLE IF NOT EXISTS Worker(Worker_ID INT AUTO_INCREMENT, Keeper_ID INT, Enclosure_ID INT, PRIMARY KEY (Worker_ID), FOREIGN KEY (Keeper_ID) REFERENCES ZooKeeper(Keeper_ID), FOREIGN KEY (Enclosure_ID) REFERENCES Enclosure (Enclosure_ID));
CREATE TABLE IF NOT EXISTS Food(
Food_ID INT AUTO_INCREMENT, 
Animal_ID INT, 
Animal_Food_ID INT, 
PRIMARY KEY (Food_ID), 
FOREIGN KEY (Animal_ID) REFERENCES Animal (Animal_ID), 
FOREIGN KEY (Animal_Food_ID) REFERENCES Animal_Food(Animal_Food_ID));


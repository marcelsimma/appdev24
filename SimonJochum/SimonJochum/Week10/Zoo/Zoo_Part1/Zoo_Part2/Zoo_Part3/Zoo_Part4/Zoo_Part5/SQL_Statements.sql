--Datenbank erstellen
DROP DATABASE zoo;
CREATE DATABASE zoo;

--Zootabellen erstellen
CREATE TABLE IF NOT EXISTS zoo (ZooID INT AUTO_INCREMENT PRIMARY KEY, Name VARCHAR(50), FoundingYear DATE);
CREATE TABLE IF NOT EXISTS zookeeper (WorkerID INT AUTO_INCREMENT PRIMARY KEY, Name VARCHAR(50));
CREATE TABLE IF NOT EXISTS enclosure (EnclosureID INT AUTO_INCREMENT PRIMARY KEY, Name VARCHAR(50));
CREATE TABLE IF NOT EXISTS animal (AnimalID INT AUTO_INCREMENT PRIMARY KEY, Name VARCHAR(50), Species VARCHAR(50));
CREATE TABLE IF NOT EXISTS food (EAN INT AUTO_INCREMENT PRIMARY KEY, Name VARCHAR(50), Unit VARCHAR(5), UnitPrice DOUBLE(10,2));

--Beziehungstabellen erstellen (bei viele zu viele Beziehungen)
CREATE TABLE IF NOT EXISTS animalfood (ID INT AUTO_INCREMENT, AnimalID INT, EAN INT, PRIMARY KEY (ID), FOREIGN KEY (AnimalID) REFERENCES animal(AnimalID), FOREIGN KEY (EAN) REFERENCES food (EAN));
CREATE TABLE IF NOT EXISTS worksin (ID INT AUTO_INCREMENT, WorkerID INT, EnclosureID INT, PRIMARY KEY (ID), FOREIGN KEY (WorkerID) REFERENCES zookeeper(WorkerID), FOREIGN KEY (EnclosureID) REFERENCES enclosure (EnclosureID));
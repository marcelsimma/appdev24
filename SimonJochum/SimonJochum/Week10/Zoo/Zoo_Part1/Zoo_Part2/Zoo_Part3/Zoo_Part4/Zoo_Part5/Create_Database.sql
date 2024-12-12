-- Datenbank erstellen
DROP DATABASE IF EXISTS zoo;
CREATE DATABASE zoo;
USE zoo;

-- Zootabellen erstellen
CREATE TABLE IF NOT EXISTS zoo (
    ZooID INT AUTO_INCREMENT PRIMARY KEY, 
    Name VARCHAR(50) NOT NULL, 
    FoundingYear DATE
    );
CREATE TABLE IF NOT EXISTS zookeeper (
    ZookeeperID INT AUTO_INCREMENT PRIMARY KEY, 
    Name VARCHAR(50) NOT NULL
    );
CREATE TABLE IF NOT EXISTS enclosure (
    EnclosureID INT AUTO_INCREMENT PRIMARY KEY, 
    Name VARCHAR(50) NOT NULL
    );
CREATE TABLE IF NOT EXISTS animal (
    AnimalID INT AUTO_INCREMENT PRIMARY KEY, 
    Name VARCHAR(50) NOT NULL, 
    Species VARCHAR(50)
    );
CREATE TABLE IF NOT EXISTS food (
    EAN INT PRIMARY KEY, 
    Name VARCHAR(50) NOT NULL, 
    Unit VARCHAR(5) NOT NULL, 
    UnitPrice DOUBLE(10,2) NOT NULL
    );

-- Beziehungstabellen erstellen (bei viele zu viele Beziehungen)
CREATE TABLE IF NOT EXISTS animal_food (
    AnimalID INT, 
    EAN INT, 
    Amount DOUBLE(3,1),
    FOREIGN KEY (AnimalID) 
    REFERENCES animal(AnimalID), 
    FOREIGN KEY (EAN) 
    REFERENCES food (EAN));
CREATE TABLE IF NOT EXISTS enclosure_zookeeper (
    ZookeeperID INT, 
    EnclosureID INT, 
    FOREIGN KEY (ZookeeperID) 
    REFERENCES zookeeper(ZookeeperID), 
    FOREIGN KEY (EnclosureID) 
    REFERENCES enclosure (EnclosureID));
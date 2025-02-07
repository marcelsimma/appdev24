-- Datenbank erstellen
DROP DATABASE IF EXISTS zoo;
CREATE DATABASE zoo;
USE zoo;

-- Zootabellen erstellen
CREATE TABLE IF NOT EXISTS zoo (
    ZooID INT AUTO_INCREMENT PRIMARY KEY, 
    `Name` VARCHAR(50) NOT NULL, 
    FoundingYear DATE
    );
CREATE TABLE IF NOT EXISTS zookeeper (
    ZookeeperID INT AUTO_INCREMENT PRIMARY KEY, 
    `Name` VARCHAR(50) NOT NULL
    );
CREATE TABLE IF NOT EXISTS enclosure (
    EnclosureID INT AUTO_INCREMENT PRIMARY KEY, 
    `Name` VARCHAR(50) NOT NULL,
    ZooID INT NOT NULL,
    FOREIGN KEY (ZooID) REFERENCES zoo(ZooID)
    );
CREATE TABLE IF NOT EXISTS animal (
    AnimalID INT AUTO_INCREMENT PRIMARY KEY, 
    `Name` VARCHAR(50) NOT NULL, 
    Species VARCHAR(50)
    );
CREATE TABLE IF NOT EXISTS food (
    EAN INT PRIMARY KEY, 
    `Name` VARCHAR(50) NOT NULL, 
    Unit VARCHAR(5) NOT NULL, 
    UnitPrice DOUBLE(10,2) NOT NULL
    );

-- Beziehungstabellen erstellen (bei viele zu viele Beziehungen)
CREATE TABLE IF NOT EXISTS animal_food (
    AnimalID INT NOT NULL,
    EAN INT NOT NULL, 
    Amount DECIMAL(8,2) NOT NULL,
    Unit VARCHAR(5) NOT NULL,
    PRIMARY KEY (AnimalID, EAN),
    FOREIGN KEY (AnimalID) REFERENCES animal(AnimalID), 
    FOREIGN KEY (EAN) REFERENCES food (EAN));

CREATE TABLE IF NOT EXISTS zookeeper_enclosure (
    ZookeeperID INT NOT NULL, 
    EnclosureID INT NOT NULL,
    PRIMARY KEY (ZookeeperID, EnclosureID),
    FOREIGN KEY (ZookeeperID) REFERENCES zookeeper(ZookeeperID), 
    FOREIGN KEY (EnclosureID) REFERENCES enclosure (EnclosureID)
    );
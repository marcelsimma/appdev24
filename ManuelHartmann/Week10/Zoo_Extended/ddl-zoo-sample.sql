-- Datenbank erstellen
DROP DATABASE IF EXISTS Zoo_Extended;
CREATE DATABASE Zoo_Extended;
USE Zoo_Extended;

-- Zootabellen erstellen
CREATE TABLE IF NOT EXISTS Zoo (
    ZooID INT AUTO_INCREMENT PRIMARY KEY, 
    `Name` VARCHAR(50) NOT NULL,
    FoundationYear DATE
    );
CREATE TABLE IF NOT EXISTS Keeper (
    KeeperID INT AUTO_INCREMENT PRIMARY KEY, 
    `Name` VARCHAR(50) NOT NULL,
    ZooID INT NOT NULL,
    FOREIGN KEY (ZooID) REFERENCES Zoo(ZooID)
    );
CREATE TABLE IF NOT EXISTS Cage (
    CageID INT AUTO_INCREMENT PRIMARY KEY, 
    `Name` VARCHAR(50) NOT NULL,
    ZooID INT NOT NULL,
    `Condition` VARCHAR(50) NULL,
    FOREIGN KEY (ZooID) REFERENCES Zoo(ZooID)
    );
CREATE TABLE IF NOT EXISTS Animal (
    AnimalID INT AUTO_INCREMENT PRIMARY KEY, 
    `Name` VARCHAR(50) NOT NULL, 
    Species VARCHAR(50)
    );
CREATE TABLE IF NOT EXISTS Food (
    FoodID INT PRIMARY KEY, 
    `Name` VARCHAR(50) NOT NULL, 
    Unit VARCHAR(5) NOT NULL, 
    UnitPrice DOUBLE(10,2) NOT NULL
    );

-- Beziehungstabellen erstellen (bei viele zu viele Beziehungen)
CREATE TABLE IF NOT EXISTS Animal_Food (
    AnimalID INT NOT NULL,
    FoodID INT NOT NULL, 
    Amount DECIMAL(8,2) NOT NULL,
    Unit VARCHAR(5) NOT NULL,
    PRIMARY KEY (AnimalID, FoodID),
    FOREIGN KEY (AnimalID) REFERENCES Animal(AnimalID), 
    FOREIGN KEY (FoodID) REFERENCES Food(FoodID));

CREATE TABLE IF NOT EXISTS Keeper_Cage (
    Keeper INT NOT NULL, 
    CageID INT NOT NULL,
    PRIMARY KEY (Keeper, CageID),
    FOREIGN KEY (Keeper) REFERENCES Keeper(KeeperID), 
    FOREIGN KEY (CageID) REFERENCES Cage(CageID)
    );
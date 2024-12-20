DROP DATABASE IF EXISTS zoo;
CREATE DATABASE zoo;
USE zoo;


CREATE TABLE IF NOT EXISTS zoo (
    ZooName VARCHAR(40) PRIMARY KEY,
    FoundingYear INTEGER NOT NULL);

CREATE TABLE IF NOT EXISTS  zooWorker (
    WorkerID INTEGER PRIMARY KEY,
    WorkerName VARCHAR(20) NOT NULL,
    ZooName VARCHAR(40)  NOT NULL,
    FOREIGN KEY (ZooName) REFERENCES zoo (ZooName));

CREATE TABLE IF NOT EXISTS enclosure (
    EnclosureID INTEGER PRIMARY KEY AUTO_INCREMENT,
    EnclosureName VARCHAR(20) NOT NULL, 
    ZooName VARCHAR(40) NOT NULL,
    FOREIGN KEY (ZooName) REFERENCES zoo (ZooName));

CREATE TABLE IF NOT EXISTS animal(
    AnimalID INTEGER PRIMARY KEY AUTO_INCREMENT,
    AnimalName VARCHAR(20) NOT NULL,
    Species VARCHAR(20) NOT NULL,
    EnclosureID INTEGER,
    FOREIGN KEY (EnclosureID) REFERENCES enclosure (EnclosureID));

CREATE TABLE IF NOT EXISTS  animalFood (
    AnimalFoodID INTEGER PRIMARY KEY AUTO_INCREMENT,
    FoodName VARCHAR(20) NOT NULL,
    Unit VARCHAR(5) NOT NULL,
    UnitPrice DOUBLE NOT NULL);

CREATE TABLE IF NOT EXISTS carelist (
    WorkerID INTEGER,
    EnclosureID INTEGER,
    FOREIGN KEY (WorkerID) REFERENCES zooWorker (WorkerID),
    FOREIGN KEY (EnclosureID) REFERENCES enclosure (EnclosureID),
    PRIMARY KEY (WorkerID, EnclosureID));

CREATE TABLE IF NOT EXISTS allFood (
    AnimalID INTEGER,
    AnimalFoodID INTEGER,
    Amount DOUBLE NOT NULL,
    FOREIGN KEY (AnimalID) REFERENCES animal (AnimalID),
    FOREIGN KEY (AnimalFoodID) REFERENCES animalFood (AnimalFoodID),
    PRIMARY KEY (AnimalID, AnimalFoodID));




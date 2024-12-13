DROP DATABASE IF EXISTS Zoodatenbank;
CREATE DATABASE Zoodatenbank;
USE Zoodatenbank;

CREATE TABLE Zoo (
    Zooname VARCHAR(30) PRIMARY KEY,
    FoundingYear INT
    -- Founding Year darf nicht in der Zukunft liegen
);

CREATE TABLE Enclosure (
    EnclosureNr INT PRIMARY KEY AUTO_INCREMENT,
    Area VARCHAR(20) NOT NULL,
    Zooname VARCHAR(30) NOT NULL,
    FOREIGN KEY (Zooname) REFERENCES Zooname(Zooname)
);

CREATE TABLE Animal (
    Animalname VARCHAR(15) PRIMARY KEY,
    Animalrace VARCHAR(25) NOT NULL,
    Habitat INT NOT NULL,
    FOREIGN KEY (Habitat) REFERENCES Enclosure(EnclosureNr)
);

CREATE TABLE Food (
    InventoryNr INT PRIMARY KEY AUTO_INCREMENT,
    Foodname VARCHAR(25) NOT NULL,
    Price DOUBLE(7,2) NOT NULL,
    Measurement VARCHAR(3) DEFAULT 'kg'
);

CREATE TABLE Zookeeper (
    KeeperID INT PRIMARY KEY AUTO_INCREMENT,
    Firstname VARCHAR(15) NOT NULL,
    Lastname VARCHAR(15) NOT NULL,
    Workplace VARCHAR(30) NOT NULL,
    FOREIGN KEY (Workplace) REFERENCES Zoo(Zooname),
    CONSTRAINT checkname UNIQUE (Firstname, Lastname)
);

CREATE TABLE Foodlist (
    Animalname VARCHAR(15) NOT NULL,
    Food INT NOT NULL,
    Amount FLOAT NOT NULL,
    CONSTRAINT Amount CHECK (Amount > 0),
    FOREIGN KEY (Animalname) REFERENCES Animal(Animalname),
    FOREIGN KEY (Food) REFERENCES Food(InventoryNr),
    PRIMARY KEY(Animalname, Food)
);

CREATE TABLE Carelist (
    KeeperID INT NOT NULL,
    EnclosureNr INT NOT NULL,
    FOREIGN KEY (KeeperID) REFERENCES Zookeeper(KeeperID),
    FOREIGN KEY (EnclosureNr) REFERENCES Enclosure(EnclosureNr),
    PRIMARY KEY(KeeperID, EnclosureNr)
);
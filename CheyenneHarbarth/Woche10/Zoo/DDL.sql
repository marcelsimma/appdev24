CREATE DATABASE Zoodatenbank
USE Zoodatenbank;

CREATE TABLE Zoo (
    'Zooname' VARCHAR(30) PRIMARY KEY,
    'FoundingYear' INT NOT NULL
);

CREATE TABLE Enclosure (
    'EnclosureNr' INT PRIMARY KEY AUTO_INCREMENT,
    'Area' VARCHAR(20) NOT NULL
);

CREATE TABLE Animal (
    'Animalname' VARCHAR(15) PRIMARY KEY,
    'Animalrace' VARCHAR(25) NOT NULL,
    'Habitat' INT NOT NULL,
    FOREIGN KEY 'Habitat' REFERENCES Enclosure (EnclosureNr)
);

CREATE TABLE Food (
    'InventoryNr' INT PRIMARY KEY AUTO_INCREMENT,
    'Foodname' VARCHAR(25) NOT NULL,
    'Price' FLOAT NOT NULL,
    'Measurement' VARCHAR(3) DEFAULT 'kg'
);

CREATE TABLE Zookeeper (
    'ID' INT PRIMARY KEY AUTO_INCREMENT,
    'Firstname' VARCHAR(15) NOT NULL,
    'Lastname' VARCHAR(15) NOT NULL,
    'Workplace' VARCHAR(30) NOT NULL,
    FOREIGN KEY 'Workplace' REFERENCES Zoo(Zooname)
);

CREATE TABLE Foodlist (
    'Animal' VARCHAR(15) NOT NULL,
    'Food' INT NOT NULL,
    'Amount' FLOAT NOT NULL,
    FOREIGN KEY 'Animal' REFERENCES Animal(Animalname),
    FOREIGN KEY 'Food' REFERENCES Food(InventoryNr)
);

CREATE TABLE Carelist (
    'Caretaker' INT NOT NULL,
    'Assigned' VARCHAR(15),
    FOREIGN KEY 'Caretaker' REFERENCES Zookeeper(ID),
    FOREIGN KEY 'Assigned' REFERENCES Animal(Animalname)
);
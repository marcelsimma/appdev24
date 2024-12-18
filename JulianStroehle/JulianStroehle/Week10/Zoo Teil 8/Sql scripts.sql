CREATE DATABASE IF NOT EXISTS dcvzoo;

USE dcvzoo;

CREATE TABLE IF NOT EXISTS zoo (
    ZooID INT PRIMARY KEY AUTO_INCREMENT,
    Name VARCHAR(50),
    FoundingYear YEAR
);

CREATE TABLE IF NOT EXISTS enclosure (
    EnclosureID INT PRIMARY KEY AUTO_INCREMENT,
    Name VARCHAR(50)
);

CREATE TABLE IF NOT EXISTS animal (
    AnimalID INT AUTO_INCREMENT,
    Name VARCHAR(50),
    Type VARCHAR(50),
    EnclosureID INT,
    PRIMARY KEY (AnimalID, EnclosureID),
    FOREIGN KEY (EnclosureID) REFERENCES enclosure(EnclosureID)
);

CREATE TABLE IF NOT EXISTS food (
    FoodNr INT PRIMARY KEY AUTO_INCREMENT,
    Name VARCHAR(50),
    Amount INT,
    Unit VARCHAR(5),
    Price DOUBLE
);

CREATE TABLE IF NOT EXISTS zookeeper (
    ZookeeperID INT PRIMARY KEY AUTO_INCREMENT,
    Name VARCHAR(20),
    LastName VARCHAR(40)
);

CREATE TABLE IF NOT EXISTS works_in (
    ID INT PRIMARY KEY AUTO_INCREMENT,
    ZookeeperID INT,
    EnclosureID INT,
    FOREIGN KEY (ZookeeperID) REFERENCES zookeeper(ZookeeperID),
    FOREIGN KEY (EnclosureID) REFERENCES enclosure(EnclosureID)
);

CREATE TABLE IF NOT EXISTS eats (
    ID INT PRIMARY KEY AUTO_INCREMENT,
    AnimalID INT,
    FoodNr INT,
    FOREIGN KEY (AnimalID) REFERENCES animal(AnimalID),
    FOREIGN KEY (FoodNr) REFERENCES food(FoodNr)
);

INSERT INTO zoo VALUES (NULL, 'Animal World', 2024);
INSERT INTO enclosure VALUES (NULL, 'Meadow');
INSERT INTO enclosure VALUES (NULL, 'Field');
INSERT INTO enclosure VALUES (NULL, 'Woods');
INSERT INTO enclosure VALUES (NULL, 'Marsh');
INSERT INTO enclosure VALUES (NULL, 'Terrarium');
INSERT INTO enclosure VALUES (NULL, 'Aquarium');
INSERT INTO enclosure VALUES (NULL, 'Terrarium (Warm)');
INSERT INTO animal VALUES (NULL, 'Stefan', 'Sheep', 1);
INSERT INTO animal VALUES (NULL, 'Safkiel', 'Sheep', 1);
INSERT INTO animal VALUES (NULL, 'Kurt', 'Cow', 2);
INSERT INTO animal VALUES (NULL, 'Karl', 'Cow', 2);
INSERT INTO animal VALUES (NULL, 'Emil', 'Squirrel', 3);
INSERT INTO animal VALUES (NULL, 'Friedolin', 'Sloth', 3);
INSERT INTO animal VALUES (NULL, 'Samuel', 'Stork', 4);
INSERT INTO animal VALUES (NULL, 'Sarah', 'Stork', 4);
INSERT INTO animal VALUES (NULL, 'Finn', 'Fish', 6);
INSERT INTO animal VALUES (NULL, 'Kevin', 'Pufferfish', 6);
INSERT INTO animal VALUES (NULL, 'Lars', 'Salmon', 6);
INSERT INTO animal VALUES (NULL, 'Helmut', 'Shark', 6);
INSERT INTO food VALUES (NULL, 'Insect Mix', 5, 'g', 0.5);
INSERT INTO food VALUES (NULL, 'Wheat', 17, 'kg', 2.45);
INSERT INTO food VALUES (NULL, 'Nuts', 80, 'g', 0.01);
INSERT INTO zookeeper VALUES (NULL, 'Alessio', 'Hawk Tuah Expert');
INSERT INTO zookeeper VALUES (NULL, 'Alex', 'Gartenbauer');
INSERT INTO zookeeper VALUES (NULL, 'Алексей', 'Градов');
INSERT INTO zookeeper VALUES (NULL, 'アレッシオ', 'ガウディオ');
INSERT INTO works_in VALUES (NULL, 1, 1);
INSERT INTO works_in VALUES (NULL, 2, 2);
INSERT INTO works_in VALUES (NULL, 3, 3);
INSERT INTO works_in VALUES (NULL, 1, 4);
INSERT INTO works_in VALUES (NULL, 2, 5);
INSERT INTO works_in VALUES (NULL, 1, 6);
INSERT INTO works_in VALUES (NULL, 4, 7);
INSERT INTO eats VALUES (NULL, 9, 1);
INSERT INTO eats VALUES (NULL, 3, 2);
INSERT INTO eats VALUES (NULL, 4, 2);
INSERT INTO eats VALUES (NULL, 5, 3);


-- Syntax
INSERT INTO zoo VALUES ('Zoo Name', FoundingYear);
INSERT INTO enclosure VALUES (NULL, 'Insert Name');
INSERT INTO animal VALUES (NULL, 'Insert Name', 'Insert Type', EnclosureID);
INSERT INTO food VALUES (NULL, 'Insert Name', InsertAmount, 'Insert Unit', Insert.Price);
INSERT INTO zookeeper VALUES (NULL, 'Insert First Name', 'Insert Last Name');
INSERT INTO works_in VALUES (NULL, ZookeeperID, EnclosureID);
INSERT INTO eats VALUES (NULL, AnimalID, FoodNr);
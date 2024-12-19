CREATE DATABASE IF NOT EXISTS dcvzoo;

USE dcvzoo;

CREATE TABLE IF NOT EXISTS zoo (
    ZooID INT PRIMARY KEY AUTO_INCREMENT,
    Name VARCHAR(50),
    FoundingYear YEAR
);

CREATE TABLE IF NOT EXISTS enclosure (
    EnclosureID INT PRIMARY KEY AUTO_INCREMENT,
    Name VARCHAR(50),
    ZooID INT,
    FOREIGN KEY (ZooID) REFERENCES zoo(ZooID)
);

CREATE TABLE IF NOT EXISTS animal (
    AnimalID INT AUTO_INCREMENT,
    Name VARCHAR(50),
    Type VARCHAR(50),
    EnclosureID INT,
    Health INT,
    Attack VARCHAR(50),
    Damage INT,
    PRIMARY KEY (AnimalID),
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

INSERT INTO zoo VALUES (1, 'Animal World', 2024);
INSERT INTO enclosure VALUES (NULL, 'Meadow', 1);
INSERT INTO enclosure VALUES (NULL, 'Field', 1);
INSERT INTO enclosure VALUES (NULL, 'Woods', 1);
INSERT INTO enclosure VALUES (NULL, 'Marsh', 1);
INSERT INTO enclosure VALUES (NULL, 'Terrarium', 1);
INSERT INTO enclosure VALUES (NULL, 'Aquarium', 1);
INSERT INTO enclosure VALUES (NULL, 'Lions Gorge', 1);
INSERT INTO animal VALUES (NULL, 'Stefan', 'G.o.a.T.', 1, 2000000000, 'Spit', 1000);
INSERT INTO animal VALUES (NULL, 'Cheyenne', 'Sheep', 1, 100, 'Bite', 20);
INSERT INTO animal VALUES (NULL, 'Barbara', 'Ram', 1, 350, 'Ram', 60);
INSERT INTO animal VALUES (NULL, 'Berkant', 'Bull', 2, 500, 'Charge', 40);
INSERT INTO animal VALUES (NULL, 'Manuel', 'Cow', 2, 200, 'Stomp', 35);
INSERT INTO animal VALUES (NULL, 'Magdalena', 'Squirrel', 3, 40, 'Nut Throw', 10);
INSERT INTO animal VALUES (NULL, 'Nico', 'Sloth', 3, 1000, 'Slow Hit', 5);
INSERT INTO animal VALUES (NULL, 'Florian', 'Stork', 4, 80, 'Poke', 30);
INSERT INTO animal VALUES (NULL, 'Simon', 'Stork', 4, 80, 'Poke', 30);
INSERT INTO animal VALUES (NULL, 'Jonas', 'Chameleon', 5, 50, 'Hidden Attack', 20);
INSERT INTO animal VALUES (NULL, 'Lucas', 'Fish', 6, 20, 'Blub', 3);
INSERT INTO animal VALUES (NULL, 'Fatma', 'Pufferfish', 6, 40, 'Spike', 15);
INSERT INTO animal VALUES (NULL, 'Oliver', 'Octopus', 6, 150, 'Tentacle Slap', 30);
INSERT INTO animal VALUES (NULL, 'Marcel', 'Shark', 6, 350, 'Strong Bite', 40);
INSERT INTO animal VALUES (NULL, 'Julian', 'Lion', 7, 450, 'Roar', 150);
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
INSERT INTO zoo (Name, FoundingYear) 
VALUES ('Schoenbrunn', '1970.10.10');
INSERT INTO enclosure (Name) 
VALUES ('Savanne'), ('Steppe'), ('Aquarium');
INSERT INTO animal (AnimalID, Name, Species, EnclosureID) 
VALUES (1, 'Simba', 'Loewe', 1), (2, 'Nala', 'Loewe', 1), (3, 'Nayla', 'Loewe', 1), 
(4, 'Benjamin', 'Elefant', 2), (5, 'Stampfi', 'Elefant', 2), (6, 'Ruessel', 'Elefant', 2), 
(7, 'Nemo', 'Clownfisch', 3), (8, 'Dori', 'Doktorfisch', 3), (9, 'Sharky', 'Hai', 3);
-- INSERT INTO food (EAN, Name, Unit, UnitPrice) 
-- VALUES (1001, 'Wasser', 'L', 0.50), (1002, 'Heu', 'KG', 1.00), (1003, 'Fleisch', 'KG', 5.00), (1004, 'Fischfutter', 'KG', 2.50);
INSERT INTO zookeeper (Name) 
VALUES ('Simon'), ('Julian'), ('Barbara');
INSERT INTO animal_food (AnimalID, EAN, Amount, Unit)
VALUES (1, 1001, 5, 'L'), (1, 1003, 10, 'KG'), (2, 1001, 6, 'L'), (2, 1003, 12, 'KG'), (3, 1001, 3, 'L'), (3, 1003, 6, 'KG'), 
    (4, 1001, 10, 'L'), (4, 1002, 20, 'KG'), (5, 1001, 12, 'L'), (5, 1002, 24, 'KG'), (6, 1001, 7, 'L'), (6, 1002, 14, 'KG'),
    (7, 1004, 2, 'KG'), (8, 1004, 2.5, 'KG'), (9, 1003, 12, 'KG');
INSERT INTO enclosure_zookeeper 
VALUES (1, 1), (1, 2), (2, 2), (3, 3);
-- 20.1) Erstelle eine neue “Organization” mit dem Namen “DCV-Grundkurs”. 
USE Mondial;
INSERT INTO mondial.organization
VALUES      ('DCV',
             'DCV-Grundkurs',
             'Bregenz',
             'A',
             'Vorarlberg',
             '2024-11-28');  
-- 20.2) Suche dir ein paar Länder aus, die Mitglied in dieser "Organization" sind und speichere die Mitgliedschaft in die Datenbank.
INSERT INTO ismember
VALUES      ('A',
             'DCV',
             'member'),
            ('B',
             'DCV',
             'member'),
            ('AUS',
             'DCV',
             'member');  
-- INSERT: Erstelle eine neue “Organization” mit dem Namen “DCV-Grundkurs”. 
-- Suche dir ein paar Länder aus, die Mitglied in dieser "Organization" sind und 
-- speichere die Mitgliedschaft in die Datenbank.

-- Neue Organisation erstellen
USE mondial;

INSERT INTO organization (Abbreviation, Name, City, Country, Province, Established)
VALUES ('DCV', 'DCV-Grundkurs', 'Bregenz', 'A', 'Vorarlberg', '2024-12-03')

-- andere Datei (Mitlgieder speichern)
USE mondial;

INSERT INTO ismember (Country, Organization, Type)
VALUES ('CH', 'DCV1', 'Kuchakästli')
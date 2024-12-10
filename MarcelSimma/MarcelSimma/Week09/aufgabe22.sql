USE mondial;

INSERT INTO organization (Abbreviation, Name, City, Country, Province, Established)
VALUES ('DCVA', 'DCV-Alumni', 'Vienna', 'A', 'Vienna', '2024-12-03');

UPDATE ismember 
SET organization = 'DCVA'
WHERE organization = 'DCV';
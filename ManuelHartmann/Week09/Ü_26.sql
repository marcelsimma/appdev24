-- Extra: Update Transnistrien 
use mondial;

update country
SET Name = 'Transnistrien',
Code = 'TTR',
Capital = 'Tiraspol',
Province = 'Moldau',
Area = 3567.01,
Population = 347251
WHERE country.Code = 'TTR';

-- Berge zu Transnistrien hinzufügen.
use mondial;

INSERT INTO mountain (Name, Mountains, Height, Type, Longitude, Latitude)
VALUES ('Bălănești', 'Bălănești', 429,'',11.1, 45.2),
('Veverița', 'Veveriț', 407,'',11.1, 45.2),
('Măgura', 'Măgur', 389,'',11.1, 45.2);

-- Verbindung von Mountain zu geo_mountain
use mondial;

INSERT INTO geo_mountain (Mountain, Country, Province)
VALUES ('Bălănești', 'TTR', 'Moldau'),
('Veverița', 'TTR', 'Moldau'),
('Măgura', 'TTR', 'Moldau');

-- Verbindung zur province herstellen.
use mondial;

insert into province
SET Name = 'Transnistrien',
Country = 'TTR',
Population = 347251,
Area = 3567.01,
Capital = 'Tiraspol',
CapProv = 'Tiraspol';

-- Verbindung zu city herstellen.
use mondial;

insert into city
SET Name = 'Tiraspol',
Country = 'TTR',
Province = 'Transnistrien',
Population = 347251,
Longitude = 11.5,
Latitude = 45;
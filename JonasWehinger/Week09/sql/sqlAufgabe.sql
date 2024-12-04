-- Aufgabe 1
USE Mondial;
SELECT Population FROM Country WHERE Name = 'Austria';
-- Aufgabe 2
USE Mondial;
SELECT RIVER FROM geo_river WHERE Country = 'A';
-- Aufgabe 3
USE mondial;
SELECT Name FROM mondial.country WHERE Name LIKE '%A';
-- Aufgabe 4
USE mondial;
SELECT SUM(cy.population) as Population
FROM continent ct, country cy, encompasses en
WHERE ct.name = en.continent
AND en.country = cy.code
AND ct.name LIKE 'Europe'
AND cy.code != 'TR';

SELECT SUM(cy.population) AS Population
FROM continent ct
JOIN encompasses en ON ct.name = en.continent
JOIN country cy ON en.country = cy.code
WHERE ct.name = 'Europe'
AND cy.code != 'TR';
-- Aufgabe 5
USE Mondial;
SELECT River 
FROM continent ct, country cy, encompasses en, geo_river riv,province pro
WHERE riv.country = pro.country
AND pro.Country = cy.Code
AND cy.Code = en.country
AND ct.name = en.continent
AND ct.Name = 'Europe';
-- Aufgabe 6
USE Mondial;
SELECT River,Length
FROM continent ct, country cy, encompasses en, geo_river riv,province pro, River ver
WHERE ver.river = riv.River
AND riv.country = pro.country
AND pro.Country = cy.Code
AND cy.Code = en.country
AND ct.name = en.continent
AND ct.Name = 'Europe';
-- Aufgabe 7
use mondial;
Select Pro.Population,Pro.name,cy.name
FROM Country cy,Province Pro
WHERE Pro.country = cy.code
AND cy.name like 'A%'
ORDER BY Pro.population DESC;
-- Aufgabe 8
USE Mondial;
SELECT gmoun.Country, Height, name
From geo_mountain gmoun, mountain moun 
WHERE moun.name = gmoun.Mountain
AND gmoun.Country = 'A'
ORDER BY Height DESC
LIMIT 1;
-- Aufgabe 9
USE Mondial;
SELECT percentage, rele.name, islands, sea
FROM  Island iz, geo_island glan, Country cy, religion rele, geo_sea gz
WHERE gz.Country = cy.code
AND iz.name = glan.island
AND glan.country = cy.Code
AND cy.code = rele.country
AND rele.Name LIKE 'MUSLIM'
AND sea LIKE 'Pacific Ocean'
AND rele.percentage > 60;

USE Mondial;
SELECT percentage, rele.name, sea
FROM  Island iz, geo_island glan, Country cy, religion rele, islandin izi
WHERE izi.island = iz.name
AND iz.name = glan.island
AND glan.country = cy.Code
AND cy.code = rele.country
AND rele.Name LIKE 'MUSLIM'
AND sea LIKE 'Pacific Ocean'
AND rele.percentage > 50;
-- Aufgabe 10
USE Mondial;
SELECT gmoun.Country, Height, rele.name
From geo_mountain gmoun, mountain moun, religion rele,  Country cy
WHERE moun.name = gmoun.Mountain
AND gmoun.Country = cy.code
AND cy.code = rele.country
AND rele.Name LIKE 'Roman Catholic'
AND Height >3000
AND rele.Percentage > 60
--Aufgabe 11
USE Mondial;
SELECT SUM(Population) AS Population, Rele.name 
FROM religion rele, country cy, encompasses ec, Continent ct
WHERE ct.name = ec.continent
AND ec.country  = cy.code
AND cy.code =  rele.country
Group by rele.name
--Aufgabe 12
USE mondial;
SELECT ct.name , ty.country,ty.name,ty.population
From continent ct , encompasses en, Country cy, City ty
WHERE ty.country = cy.code
AND ct.name = en.Continent
AND en.Country = cy.code
AND  ct.name LIKE 'America'
ORDER BY population DESC
LIMIT 3
-- Aufgabe 13
USE mondial;
SELECT en.Continent ,SUM(cy.population) / (SELECT SUM(cy.population)
FROM country cy) * 100 as Summe
FROM country cy, encompasses en
WHERE cy.code = en.country
AND en.Continent  like 'Europe'
GROUP BY en.continent;
-- Aufgabe 14

-- Aufgabe 15
SELECT Count(cy.name) AS citycount, ct.name
FROM city cy, country ct
WHERE cy.country = ct.code
GROUP BY ct.name
HAVING citycount = 3;
-- Aufgabe 16
SELECT en.Continent, MAX(mou.Height) AS Height
FROM mountain mou, encompasses en, geo_mountain gmoun
WHERE mou.Name = gmoun.Mountain
AND gmoun.Country = en.Country
GROUP BY en.Continent;
-- Aufgabe 17
SELECT org.Name, COUNT(meme.Organization) AS Members 
FROM organization org, ismember meme
WHERE meme.Organization = org.Abbreviation AND org.Country = 'A'
GROUP BY org.Name
ORDER BY org.Name;
-- Aufgabe 18
select gmoun.Country,lk.name AS Seaname ,gmoun.Mountain
from mountain mt, geo_mountain gmoun, lake lk , geo_lake glk
WHERE glk.Lake = lk.name
AND lk.Depth > 100
AND mt.Height > 1500
AND gmoun.Mountain = mt.Name 
ORDER BY gmoun.country;
-- Aufgabe 19
SELECT  cy.Name , gsea.Sea
FROM Country cy, geo_sea gsea
WHERE cy.Code = gsea.Country;
-- Aufgabe 20
insert INTO organization value('DCVG', 'DCV-Grundkurs','ofcompton','A','Voralberg','2001.12.03' );
 
 
insert INTO ismember Values ('A','DCVG','member');
insert INTO ismember Values ('BRU','DCVG','member');
insert INTO ismember Values ('BS','DCVG','member');
-- Aufgabe 21
SELECT * FROM mondial.ismember WHERE Organization = 'DCVG'
-- Aufgae 22
UPDATE ismember
SET ismember.Organization = 'ADCVG' WHERE country = 'A'
and ismember.Organization = 'DCVG';

UPDATE ismember
SET ismember.Organization = 'ADCVG' WHERE country = 'BRU'
and ismember.Organization = 'DCVG';

UPDATE ismember
SET ismember.Organization = 'ADCVG' WHERE country = 'BS'
and ismember.Organization = 'DCVG' ;
-- Aufgabe 23
DELETE FROM organization WHERE Abbreviation = 'DCVG'
-- Aufgabe 24
UPDATE mountain
SET Mountain.Height = '3798' WHERE name = 'Großglockner'
-- Aufgabe 25
Insert Into Country(Name,Code,Capital,Province,Area,Population)
Value ('Transnistrien','Tra','capitalCity','capitalPro','20541','23')
Insert Into encompasses(Country,Continent,Percentage)
Value('Tra','Europe','100')
-- Aufgabe 26
INSERT INTO geo_mountain
VALUES ('MouBig', 'Tra', 'capitalPro');
INSERT INTO geo_mountain
VALUES ('BigMou', 'Tra', 'capitalPro');
INSERT INTO mountain
VALUES ('MouBig', NULL, 580, NULL, NULL, NULL);
INSERT INTO mountain
VALUES ('BigMou', NULL, 270, NULL, NULL, NULL);
INSERT INTO Province
VALUES ('CapitalPro','Tra','2','55','capitalCity','capitalPro')
INSERT INTO city
VALUES ('capitalCity', 'Tra', 'capitalPro', 12432, NULL, NULL);
-- Aufgabe 27
UPDATE country SET Name = 'Türkiye' WHERE Name = 'Turkey';
-- Aufgabe 28
UPDATE province, country
SET province.Population = country.Population / 16
WHERE province.Country = country.Code
AND province.Country = 'D';
--Aufgabe 29
Update Country SET Capital = 'Nusantara' WHERE Capital = 'Bangkok'

Update City SET name = 'Nusantara' WHERE name = 'Bangkok'
AND Province = 'Thailand'
AND country = 'THA'
--Aufgabe 30
INSERT INTO organization VALUES ('VG', 'Visegard Group', 'Visegard', 'H', 'Brudapest ', '2001-02-11')
 
INSERT INTO ismember VALUES ('H', 'VG', 'member')
INSERT INTO ismember VALUES ('A', 'VG', 'member')
INSERT INTO ismember VALUES ('CZ', 'VG', 'member')
INSERT INTO ismember VALUES ('CH', 'VG', 'member')
INSERT INTO ismember VALUES ('VG', 'VG', 'Chef')
--Aufgabe 31

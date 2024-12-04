//Aufgabe 1
USE mondial;
Select population FROM country WHERE Name = 'Austria' 

//Aufgabe 2
SELECT River FROM geo_river WHERE Country = 'A';

//Aufgabe 3
SELECT Name FROM mondial.country WHERE Name LIKE '%A'
//Aufgabe 13
SELECT ROUND(SUM(country.Population/(SELECT SUM(country.Population) FROM country)*100), 2) AS PopulationPercent
FROM country
JOIN encompasses ON country.Code = encompasses.Country
WHERE encompasses.Continent = 'Europe';
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
and ismember.Organization = 'DCVG' 
;
UPDATE ismember 
SET ismember.Organization = 'ADCVG' WHERE country = 'BRU'
and ismember.Organization = 'DCVG' 
;
UPDATE ismember 
SET ismember.Organization = 'ADCVG' WHERE country = 'BS'
and ismember.Organization = 'DCVG' ;
-- andere wariante:
/*
prepare member_update from 	'UPDATE ismember SET ismember.Organization = ? WHERE country = ? and ismember.Organization = ?';

set @orga = 'ADCVG';
set @country = 'A';
set @alte_orga = 'DCVG';

execute member_update using @orga, @country, @alte_orga;
*/
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
VALUES ('capitalPro','Tra','12','50','capitalCity','capitalPro')
INSERT INTO city
VALUES ('capitalCity', 'Tra', 'capitalPro', 12432, NULL, NULL);

-- Aufgabe 27
UPDATE country SET Name = 'Türkiye' WHERE Name = 'Turkey';

-- Aufgabe 28
USE mondial;

UPDATE province, country
SET province.Population = country.Population / 16
WHERE province.Country = country.Code
AND province.Country = 'D';

-- Aufgabe 29
Update Country SET Capital = 'Nusantara' WHERE Capital = 'Bangkok' 

-- Aufgabe 30
INSERT INTO organization VALUES ('VG', 'Visegard Group', 'Visegard', 'H', 'Brudapest ', '2001-02-11')

INSERT INTO ismember VALUES ('H', 'VG', 'member') 
INSERT INTO ismember VALUES ('A', 'VG', 'member')
INSERT INTO ismember VALUES ('CZ', 'VG', 'member')
INSERT INTO ismember VALUES ('CH', 'VG', 'member') 
INSERT INTO ismember VALUES ('VG', 'VG', 'Chef') 
-- Aufgabe 31

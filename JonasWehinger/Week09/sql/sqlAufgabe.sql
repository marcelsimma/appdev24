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


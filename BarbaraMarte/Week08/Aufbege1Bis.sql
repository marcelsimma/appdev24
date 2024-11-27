1.	Write out Austria:
	SELECT * from mondial.country where name = 'Austria';
2.	Write out all Countrys starting with an A:
	SELECT NAME FROM mondial.country WHERE NAME LIKE 'A%';
3.	Write out Erope and Area information:
	SELECT * FROM mondial.continent WHERE NAME = 'Europe';
4.	Write out all Rivers from the Country A (Austria)
	SELECT * FROM geo_river WHERE Country LIKE 'A'; 
	SELECT * FROM geo_river WHERE country = 'A';
5.	Write out the total Population from Europe
	SELECT SUM(Population) AS total_Population, Continent FROM 	encompasses, country WHERE Continent = 'Europe' AND country.Code = 	encompasses.Country;
6.	Welche Flüsse fließen duch Europa? Nur den Flussnamen
	SELECT geo_river.River FROM encompasses, geo_river WHERE 		encompasses.Country = geo_river.Country AND encompasses.Continent = 	'Europe';
7.	Alle Flüsse die durch Europa fließen, sortiert bei deren länge
	SELECT DISTINCTgeo_river.River, river.Length FROM encompasses, 	geo_river, river 	WHERE geo_river.River = river.Name AND 	encompasses.Country = 	geo_river.Country AND 	encompasses.Continent = 'Europe' ORDER BY 	river.Length;
8.	Alle Länder die mit einem A anfangen, und deren Bundesländer mit Einwohnerzahl, sortiert nach Einwohnerzahl
	SELECT DISTINCT Country.code, province.population, province.name
	FROM Country, Province
	WHERE Country.code = province.country and country.code LIKE 'A%'
	ORDER BY country.code ASC;
9.	Was ist der größte Berg von Österreich, wie hoch ist er?
	SELECT mountain.Name, mountain.Height FROM mountain, geo_mountain WHERE geo_mountain.Mountain = mountain.Name AND geo_mountain.Country = 'A' ORDER BY mountain.Height DESC LIMIT 1;

10.	Alle Inseln im Pazifik mit >50% Islamischen bekentniss 
SELECT island.name
FROM island, religion, geo_island, geo_sea, country, province
WHERE religion.country = country.code
AND country.code = province.country
AND province.name = geo_island.province
AND geo_island.country = province.country
AND geo_sea.country = country.code
AND geo_island.Island = island.name
AND geo_sea.sea LIKE 'Pacific'
AND religion.name = 'Muslim' AND religion.Percentage > 50;

SELECT count(i.name) 
FROM island i, religion r, geo_island gi, province p, country cy, geo_sea gs
WHERE r.country = cy.code
AND cy.code = p.country
AND p.name = gi.province
AND gi.country = p.country 
AND gs.country = cy.code
AND gi.island = i.name
AND gs.sea LIKE 'Pacific%'
AND r.name = 'Muslim' AND r.percentage >50;

SELECT i.name 
FROM island i, religion r, geo_island gi, province p, country cy, geo_sea gs
WHERE r.country = cy.code
AND cy.code = p.country
AND p.name = gi.province
AND gi.country = p.country 
AND gs.country = cy.code
AND gi.island = i.name
AND gs.sea LIKE 'Pacific%'
AND r.name = 'Muslim' AND r.percentage >50;

11. Alle Länder mit einem 
    SELECT * FROM Country, religion WHERE religion.Country = Country.code AND religion.Name = 'Muslim' AND religion.Percentage >50;
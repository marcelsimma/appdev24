USE Mondial;

-- 1) Wie viele Einwohner hat Österreich?
SELECT * from country WHERE name = 'Austria';

-- 2) Welche Flüsse fließen durch Österreich?
SELECT name FROM country WHERE name LIKE 'A%';

-- 3) Alle Länder die mit einem A anfangen
SELECT * FROM continent WHERE name = 'Europe';

-- 4) Wie viele Einwohner hat der Kontinent Europa?
SELECT * FROM geo_river WHERE country = 'A';

-- 5) Welche Flüsse fließen durch Europa (nur den Flussnamen)?
SELECT SUM(Population) AS total_Population, Continent FROM 	encompasses, country WHERE Continent = 'Europe' AND country.Code = 	encompasses.Country;

-- 6) Alle Flüsse die durch Europa fließen (nur Flüsse und deren Länge), sortiert nach Länge
SELECT geo_river.River FROM encompasses, geo_river WHERE encompasses.Country = geo_river.Country AND encompasses.Continent = 'Europe';


SELECT DISTINCTgeo_river.River, river.Length 
FROM encompasses, geo_river, river 
WHERE geo_river.River = river.Name 
AND encompasses.Country = geo_river.Country 
AND encompasses.Continent = 'Europe' 
ORDER BY river.Length;

-- 7) Alle Länder die mit einem A anfangen und deren Bundesländer mit Einwohnerzahl, sortiert nach Einwohnerzahl
SELECT DISTINCT Country.code, province.population, province.name
FROM Country, Province
WHERE Country.code = province.country and country.code LIKE 'A%'
ORDER BY country.code ASC;

-- 8) Was ist der größte Berg von Österreich? Wie hoch ist er?
SELECT mountain.Name, mountain.Height 
FROM mountain, geo_mountain 
WHERE geo_mountain.Mountain = mountain.Name 
AND geo_mountain.Country = 'A' 
ORDER BY mountain.Height DESC LIMIT 1;

-- 9) Alle Inseln im Pazifik mit >50% islamischem Bekenntnis
SELECT i.name, r.percentage, gi.country
FROM island i, religion r, islandIn ii, geo_island gi
-- Beziehung Island -islandIn
WHERE i.name = ii.island
-- Beziehung Island - geo_island
AND i.name = gi.island
-- Beziehung geo_island - Religion
AND gi.country = r.country
AND ii.sea LIKE 'Pacific%'
AND r.name = 'Muslim' 
AND r.Percentage > 50;

-- 10)Alle 3000er, welche in einem Land sind, welches zu mindestens 60% römisch Katholisch ist
SELECT m.name
FROM mountain m, geo_mountain gm, province p, country cy, religion r
WHERE cy.code = p.country
AND gm.Country = p.country
AND gm.Province = p.name
AND m.name = gm.mountain
AND r.country = cy.code
AND m.Height > 3000
AND r.name like 'Roman%' 
AND r.percentage > 60;

-- 11) Einwohnerzahl pro Religion
SELECT r.name,
SUM(c.Population * (r.Percentage / 100))/1000000 AS GesamteGlaeubige
FROM Religion r
JOIN Country c ON r.Country = c.Code
GROUP BY r.name
ORDER BY GesamteGlaeubige;

-- 12) Welches sind die 3 größten Städte von Amerika (Kontinent)?
SELECT * 
FROM city 
JOIN encompasses 
ON city.Country = encompasses.Country 
WHERE encompasses.Continent = 'America' 
ORDER BY Population
DESC LIMIT 3;

-- 13) Wie viel Prozent der Menschen leben im Kontinent Europa?
SELECT ROUND(SUM(country.Population/(SELECT SUM(country.Population) 
FROM country)*100),2) AS PopulationPercent 
FROM country 
JOIN encompasses ON country.Code = encompasses.Country 
WHERE encompasses.Continent = 'Europe';

-- 14) Das Unabhängigkeitsdatum von Ländern die eine Wüste haben und die ethnische Gruppe African
SELECT DISTINCT politics.Independence, geo_desert.Country
FROM politics, geo_desert
JOIN ethnicgroup ON geo_desert.Country = ethnicgroup.Country
WHERE ethnicgroup.Country = politics.Country
AND ethnicgroup.Name = 'African';

-- 15) Welche Länder haben genau 3 Städte? Welche Länder sind dies?
SELECT country.Name AS CountryName, COUNT(*) AS AmountCities 
FROM city 
JOIN country ON city.Country = country.Code 
GROUP BY country.Name HAVING AmountCities = 3;

-- 16) Was ist der größte Berg pro Kontinent? Wie hoch sind diese?
WITH maxMountains as (SELECT DISTINCT encompasses.continent, geo_mountain.Mountain, mountain.height, RANK() over (
partition by encompasses.continent order by mountain.Height desc) AS mountainRank 
FROM mountain
JOIN geo_mountain ON mountain.Name = geo_mountain.Mountain
JOIN encompasses On geo_mountain.Country = encompasses.Country)
SELECT * from maxMountains 
WHERE mountainRank = 1;
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
SELECT DISTINCT m.name, m.Height
FROM mountain m, geo_mountain gm, province p, country cy, religion r
WHERE cy.code = p.Country
AND gm.country = p.country
AND gm.Province = p.Name
AND m.name = gm.mountain
AND r.country = cy.code
AND m.Height > 3000
AND r.name LIKE 'Roman %'  
AND r.Percentage > 60
ORDER BY m.Height

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

-- 17) Welche Organisationen haben deren Hauptsitz in Österreich? Wie viele Mitglieder haben diese Organisationen?
SELECT organization.Name, COUNT(ismember.Organization) AS Members 
FROM organization, ismember 
WHERE ismember.Organization = organization.Abbreviation 
AND organization.Country = 'A' 
GROUP BY organization.Name 
ORDER BY organization.Name;

-- 18) Alle Länder mit mindestens einem See mit mindestens 100 Meter Tiefe und mindestens einem Berg mit mindestens 1500 Höhenmeter
SELECT DISTINCT cy.name
FROM lake l, geo_lake gl, mountain m, geo_mountain gm, country cy
WHERE gl.Country = cy.code
AND gl.Lake = l.Name

AND l.Depth > 100
AND gm.Country = cy.code
AND gm.mountain = m.name
AND m.Height > 1500;

-- 19) Alle Länder, nur die Namen, und wenn sie haben, das Meer dazu
SELECT DISTINCT country.name, geo_sea.sea
FROM country
LEFT JOIN geo_sea ON country.Code = geo_Sea.Country;

--20.1) Erstelle eine neue “Organization” mit dem Namen “DCV-Grundkurs”. 
INSERT INTO mondial.organization VALUES ('DCV', 'DCV-Grundkurs', 'Bregenz', 'A', 'Vorarlberg', '2024-11-28');

--20.2) Suche dir ein paar Länder aus, die Mitglied in dieser "Organization" sind und speichere die Mitgliedschaft in die Datenbank.
INSERT INTO ismember VALUES ('A', 'DCV', 'member'), ('CH', 'DCV', 'member'), ('D', 'DCV', 'member');

--21)  Gib alle Mitglieder der neuen Organization aus. Sind alle Mitglieder dabei, die du hinzugefügt hast?
SELECT * FROM ismember WHERE Organization = 'DCV';

-- 22.1) Wir gehen 2 Monate in die Zukunft: Der Kurs ist vorbei. Jetzt gibt es eine neue internationale Organisation: “Alumni DCV-Grundkurs”.
INSERT INTO organization VALUES ('ALDCV', 'Alumni DCV-Grundkurs', 'Bregenz', 'A', 'Vorarlberg', '2025-01-29');

-- 22.2) Alle Mitglieder von “DCV-Grundkurs” werden nun automatisch Mitglied in der Organisation “Alumni DCV Grundkurs”. Die Mitgliedschaft bei "DCV-Grundkurs" endet im selben Moment.
SET SQL_SAFE_UPDATES = 0;
UPDATE ismember SET Organization = 'ALDCV' 
WHERE Organization = 'DCV';

-- 23)Nachdem die Organisation “DCV-Grundkurs” keine Mitglieder mehr hat, soll diese gelöscht werden.
DELETE FROM organization 
WHERE Abbreviation = 'DCV'

-- 24) Großglockner Größe updaten
UPDATE mondial.mountain 
SET Height = 3798 
WHERE mountain.Name = 'Grossglockner';

-- 25.1) Erstelle das Land Transnistrien. Es liegt in Europa.
INSERT INTO country VALUES ('Transnistria', 'PMR', 'Tiraspol', 'Tiraspol', 4163, 465200)

-- 25.2) Wenn du anschließend einen alle europäischen Staaten inkl. Namen selektierst, soll auch Transnistrien in der Ergebnisliste sein.
INSERT INTO encompasses VALUES ('PMR', 'Europe', 100);

--26) Hat keine nennenswerte Berge oder Erhöhungen, Hauptstadt von Transnistrien
INSERT INTO city VALUES ('Tiraspol', 'PMR', 'Transnistria', 347251, null, null);

--27) Ändere den Namen der Türkei auf "Türkiye".
UPDATE country
SET Name = 'Turkiye'
WHERE Name = 'Turkey'
AND Code = 'TR'
AND Capital ='Ankara';

--28)  Ändere die Einwohnerzahl der Deutschen Bundesländer: In jedem Bundesland wohnt zukünftig jeweils 1/16 der Gesamtbevölkerung Deutschlands
UPDATE province  
SET Population = (SELECT Population FROM country WHERE Code = 'D') / 16 
WHERE Country = 'D';

--29)  Thailand hat eine neue Hauptstadt: Nusantara. Speichere das in die Datenbank.
UPDATE country 
SET Capital = 'Nusantara' 
WHERE Name = 'Thailand';
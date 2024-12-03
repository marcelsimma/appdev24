USE Mondial;

-- 1) Wie viele Einwohner hat Österreich?
SELECT Name, Population FROM country WHERE Name = 'Austria';

-- 2) Welche Flüsse fließen durch Österreich?
SELECT * FROM mondial.geo_river WHERE Country = 'A';

-- 3) Alle Länder die mit einem A anfangen
SELECT * FROM mondial.country WHERE Name LIKE 'A%';

-- 4) Wie viele Einwohner hat der Kontinent Europa?
SELECT SUM(Population) AS total_Population FROM mondial.country, mondial.encompasses WHERE encompasses.Continent = 'Europe' AND country.Code = encompasses.Country;

-- 5) Welche Flüsse fließen durch Europa (nur den Flussnamen)?
SELECT River FROM geo_river, encompasses WHERE encompasses.Continent = 'Europe' AND geo_river.Country = encompasses.Country;

-- 6) Alle Flüsse die durch Europa fließen (nur Flüsse und deren Länge), sortiert nach Länge
SELECT DISTINCT (geo_river.River), river.Length FROM geo_river, encompasses, river WHERE encompasses.Continent = 'Europe' AND geo_river.Country = encompasses.Country AND river.Name = geo_river.River ORDER BY river.Length;

-- 7.1) Alle Länder die mit einem A anfangen und deren Bundesländer mit Einwohnerzahl, sortiert nach Einwohnerzahl
SELECT country.Name, city.Name, city.Population FROM country LEFT JOIN city ON country.Code = city.Country WHERE country.Name LIKE 'A%' ORDER BY city.Population;
-- 7.2) Alle Länder die mit einem A anfangen und deren Bundesländer mit Einwohnerzahl, sortiert nach Einwohnerzahl 
SELECT country.Name, city.Province, city.Population FROM country LEFT JOIN city ON country.Code = city.Country WHERE country.Name LIKE 'A%' ORDER BY city.Population;

-- 8 & 13) Was ist der größte Berg von Österreich? Wie hoch ist er?
SELECT Name, MAX(mountain.Height) AS HighestMountain FROM mountain JOIN geo_mountain ON mountain.Name = geo_mountain.Mountain WHERE geo_mountain.Country = 'A' GROUP BY Name LIMIT 1;

-- 9) Alle Inseln im Pazifik mit >50% islamischem Bekenntnis
SELECT islandin.Island, islandin.Sea, religion.Name AS Religion, religion.Percentage FROM islandin, religion JOIN geo_island ON religion.Country = geo_island.Country WHERE islandin.Sea = 'Pacific Ocean' AND islandin.Island = geo_island.Island AND religion.Name = 'Muslim' AND religion.Percentage > 50;

-- 10)Alle 3000er, welche in einem Land sind, welches zu mindestens 60% römisch Katholisch ist
SELECT DISTINCT mountain.Name, mountain.Height FROM mountain, religion, geo_mountain WHERE mountain.Name = geo_mountain.Mountain AND geo_mountain.Country = religion.Country AND mountain.Height > 3000 AND religion.Name = 'Roman Catholic' AND religion.Percentage >= 60 ORDER BY mountain.Height;

-- 11) Einwohnerzahl pro Religion
SELECT religion.Name, SUM(country.Population) AS Population FROM religion JOIN country ON religion.Country = country.Code GROUP BY religion.Name;

-- 12) Welches sind die 3 größten Städte von Amerika (Kontinent)?
SELECT * FROM city JOIN encompasses ON city.Country = encompasses.Country WHERE encompasses.Continent = 'America' ORDER BY POPULATION DESC LIMIT 3;

-- 13) Wie viel Prozent der Menschen leben im Kontinent Europa?
SELECT ROUND(SUM(country.Population/(SELECT SUM(country.Population) FROM country)*100),2) AS PopulationPercent FROM country JOIN encompasses ON country.Code = encompasses.Country WHERE encompasses.Continent = 'Europe';

-- 14) Das Unabhängigkeitsdatum von Ländern die eine Wüste haben und die ethnische Gruppe African
SELECT DISTINCT (geo_desert.Country), politics.Independence FROM politics, geo_desert LEFT JOIN ethnicgroup ON geo_desert.Country = ethnicgroup.Country WHERE ethnicgroup.Country = politics.Country AND ethnicgroup.Name = 'African';

-- 15) Welche Länder haben genau 3 Städte? Welche Länder sind dies?
SELECT country.Name AS CountryName, COUNT(*) AS AnzStaedte FROM mondial.city JOIN mondial.country ON city.Country = country.Code GROUP BY country.Name HAVING COUNT(*) = 3;

-- 16) Was ist der größte Berg pro Kontinent? Wie hoch sind diese?
SELECT DISTINCT encompasses.Continent, geo_mountain.Mountain, mountain.Height AS MaxHeight FROM mountain JOIN geo_mountain ON mountain.Name = geo_mountain.Mountain JOIN encompasses ON geo_mountain.Country = encompasses.Country WHERE mountain.Height = (SELECT MAX(m.Height) FROM mountain m JOIN geo_mountain gm ON m.Name = gm.Mountain JOIN encompasses e ON gm.Country = e.Country WHERE e.Continent = encompasses.Continent) ORDER BY MaxHeight DESC;

-- 17) Welche Organisationen haben deren Hauptsitz in Österreich? Wie viele Mitglieder haben diese Organisationen?
SELECT organization.Name, COUNT(ismember.Organization) AS Members FROM organization, ismember WHERE ismember.Organization = organization.Abbreviation AND organization.Country = 'A' GROUP BY organization.Name ORDER BY organization.Name;

-- 18) Alle Länder mit mindestens einem See mit mindestens 100 Meter Tiefe und mindestens einem Berg mit mindestens 1500 Höhenmeter
SELECT DISTINCT country.Name FROM country, geo_lake, lake, geo_mountain, mountain WHERE geo_lake.Country = country.Code AND geo_lake.Lake = lake.Name AND lake.Depth > 100 AND geo_mountain.Country = country.Code AND geo_mountain.Mountain = mountain.Name AND mountain.Height > 1500 ORDER BY country.Name;

-- 19) Alle Länder, nur die Namen, und wenn sie haben, das Meer dazu
SELECT DISTINCT country.Name, geo_sea.Sea FROM country LEFT JOIN geo_sea ON country.Code = geo_Sea.Country;

-- 20.1) Erstelle eine neue “Organization” mit dem Namen “DCV-Grundkurs”. 
INSERT INTO mondial.organization VALUES ('DCV', 'DCV-Grundkurs', 'Bregenz', 'A', 'Vorarlberg', '2024-11-28');
-- 20.2) Suche dir ein paar Länder aus, die Mitglied in dieser "Organization" sind und speichere die Mitgliedschaft in die Datenbank.
INSERT INTO ismember VALUES ('A', 'DCV', 'member'), ('B', 'DCV', 'member'), ('AUS', 'DCV', 'member');

-- 21) Gib alle Mitglieder der neuen Organization aus. Sind alle Mitglieder dabei, die du hinzugefügt hast?
SELECT * FROM ismember WHERE Organization = 'DCV';

-- 22.1) Wir gehen 2 Monate in die Zukunft: Der Kurs ist vorbei. Jetzt gibt es eine neue internationale Organisation: “Alumni DCV-Grundkurs”. 
INSERT INTO organization VALUES ('ADCV', 'Alumni DCV-Grundkurs', 'Bregenz', 'A', 'Vorarlberg', '2025-01-28');
-- 22.2) Alle Mitglieder von “DCV-Grundkurs” werden nun automatisch Mitglied in der Organisation “Alumni DCV Grundkurs”. Die Mitgliedschaft bei "DCV-Grundkurs" endet im selben Moment.
UPDATE ismember SET Organization = 'ADCV' WHERE Organization = 'DCV' AND Country = 'A';

-- 23)Nachdem die Organisation “DCV-Grundkurs” keine Mitglieder mehr hat, soll diese gelöscht werden.
DELETE FROM organization WHERE Abbreviation = 'DCV'; 

-- 24) Großglockner Größe updaten
UPDATE mondial.mountain SET Height = 3798 WHERE mountain.Name = 'Grossglockner';

-- 25.1) Erstelle das Land Transnistrien. Es liegt in Europa. 
INSERT INTO country VALUES ('Transnistria', 'PMR', 'Tiraspol', 'Transnistria', 3567, 347251) & INSERT INTO encompasses VALUES ('PMR', 'Europe', 100);
-- 25.2) Wenn du anschließend einen alle europäischen Staaten inkl. Namen selektierst, soll auch Transnistrien in der Ergebnisliste sein.
SELECT country.Name, Country, Continent FROM encompasses LEFT JOIN country ON country.Code = encompasses.Country WHERE Continent = 'Europe';

--26.1)Speichere die höchsten drei Berge (gibt nur 2). Prüfe die Ergebnisse mit einem SELECT.
INSERT INTO geo_mountain VALUES ('4 Stolba', 'PMR', 'Transnistria'), ('Chervonka', 'PMR', 'Transnistria'); 
INSERT INTO mountain VALUES ('4 Stolba', '4 Stolba', 10, null, null, null), ('Chervonka', 'Chervonka', 190, null, null, null);
-- 26.1 Prüfung) 
SELECT * FROM geo_mountain JOIN mountain ON mountain.Mountains = geo_mountain.Mountain WHERE Country = 'PMR';
--26.2) sowie die Hauptstadt von Transnistrien in die Datenbank.
INSERT INTO city VALUES ('Tiraspol', 'PMR', 'Transnistria', 347251, null, null);

-- 27) Ändere den Namen der Türkei auf "Türkiye".
UPDATE mondial.country SET Name = 'Türkiye' WHERE Name = 'Turkey' AND Code = 'TR' AND Capital = 'Ankara';

-- 28) Ändere die Einwohnerzahl der Deutschen Bundesländer: In jedem Bundesland wohnt zukünftig jeweils 1/16 der Gesamtbevölkerung Deutschlands
UPDATE province  SET Population = (SELECT Population FROM country WHERE Code = 'D') / 16 WHERE Country = 'D';

-- 29) Thailand hat eine neue Hauptstadt: Nusantara. Speichere das in die Datenbank.
UPDATE country SET Capital = 'Nusantara' WHERE Name = 'Thailand';

-- 30.1) Es gibt eine weitere "Organization", die nicht in unserer Datenbank vorhanden ist: die Visegrad Gruppe.
INSERT INTO organization VALUES ('V4', 'Visegrád-Gruppe', 'Visegrad', 'H', 'Szentendre', '1991-02-15');
-- 30.2) Erstelle die "Organization" und ordne ihr Mitglieder zu. Die Hauptstadt dieses Bündnisses ist die ungarische Stadt Visegrad.
INSERT INTO ismember VALUES ('PL', 'V4', 'member'), ('CZ', 'V4', 'member'), ('SK', 'V4', 'member'), ('H', 'V4', 'member');

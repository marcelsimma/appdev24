   -- 1.	Write out Austria:
        SELECT * from mondial.country 
        WHERE NAME = 'Austria';

   -- .	Write out all Countrys starting with an A:
        SELECT NAME FROM mondial.country WHERE NAME LIKE 'A%';

    --2.	Write out all Rivers from the Country A (Austria)
        SELECT * FROM geo_river 
        WHERE Country 
        LIKE 'A';

        SELECT * FROM geo_river 
        WHERE country = 'A';    
        
    --3.	Write out Erope and Area information:
        SELECT * FROM mondial.continent WHERE NAME = 'Europe';

    --4.	Write out the total Population from Europe
        SELECT SUM(Population) AS total_Population, Continent 
        FROM 	encompasses, country 
        WHERE Continent = 'Europe' 
        AND country.Code = 	encompasses.Country;


    --5.	Welche Flüsse fließen duch Europa? Nur den Flussnamen
        SELECT geo_river.River 
        FROM encompasses, geo_river 
        WHERE encompasses.Country = geo_river.Country 
        AND encompasses.Continent = 	'Europe';

    --6.	Alle Flüsse die durch Europa fließen, sortiert bei deren länge
        SELECT DISTINCTgeo_river.River, river.Length 
        FROM encompasses, 	geo_river, river 	
        WHERE geo_river.River = river.Name 
        AND	encompasses.Country = geo_river.Country 
        AND	encompasses.Continent = 'Europe' 
        ORDER BY 	river.Length;

    --7.	Alle Länder die mit einem A anfangen, und deren Bundesländer mit Einwohnerzahl, sortiert nach Einwohnerzahl
        SELECT DISTINCT Country.code, province.population, province.name
        FROM Country, Province
        WHERE Country.code = province.country 
        AND country.code 
        LIKE 'A%'
        ORDER BY country.code ASC;

    --8.	Was ist der größte Berg von Österreich, wie hoch ist er?
        SELECT mountain.Name, mountain.Height 
        FROM mountain, geo_mountain 
        WHERE geo_mountain.Mountain = mountain.Name 
        AND geo_mountain.Country = 'A' 
        ORDER BY mountain.Height 
        DESC LIMIT 1;

    --9.	Alle Inseln im Pazifik mit >50% Islamischen bekentniss 
        SELECT island.name -- funktioniert nicht. Weiß nicht wieso
        FROM island, religion, geo_island, geo_sea, country, province
        WHERE religion.country = country.code
        AND country.code = province.country
        AND province.name = geo_island.province
        AND geo_island.country = province.country
        AND geo_sea.country = country.code
        AND geo_island.Island = island.name
        AND geo_sea.sea LIKE 'Pacific'
        AND religion.name = 'Muslim' 
        AND religion.Percentage > 50;

        SELECT count(i.name) -- rechnet die Reihen aus. Gibt aber keine anderen Werte aus
        FROM island i, religion r, geo_island gi, province p, country cy, geo_sea gs
        WHERE r.country = cy.code 
        AND cy.code = p.country
        AND p.name = gi.province    -- FUNKTIONIERT NICHT !!!
        AND gi.country = p.country 
        AND gs.country = cy.code
        AND gi.island = i.name
        AND gs.sea LIKE 'Pacific%'
        AND r.name = 'Muslim' 
        AND r.percentage >50;


        SELECT i.name, r.Percentage 
        FROM island i , islandIn ii, geo_island gi, religion r 
        -- Beziehung Island - islandIn
        WHERE i.name = ii.island

        -- Beziehung Island -ge_island
        AND i.name = gi.island

        -- geo_island - religion
        AND gi.country = r.country
        
        -- Religion = Muslim und > 50%
        AND r.name = 'Muslim'
        AND r.percentage > 50
        AND ii.sea LIKE 'Pacific %';


    -- Alle Länder mit mehr als 50% Muslimen
        SELECT * FROM Country, religion 
        WHERE religion.Country = Country.code
        AND religion.Name = 'Muslim' 
        AND religion.Percentage >50;

    --10. Alle 3000er, welche in einem Land sind, welches mindestens 60% römisch Katholisch ist
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

    --11. Einwohnerzahl pro religion
        SELECT r.name, 
        SUM(c.Population * (r.Percentage/100))/1000000 AS GesamtGläubige
        FROM Religion r
        JOIN Country c ON r.Country = c.Code
        GROUP BY r.name
        ORDER BY GesamtGläubige;

    --12. Welches sind die 3 größten Städte von Amerika (Kontinent)?
        -- Order by City population
        SELECT * 
        FROM city
        JOIN encompasses 
        ON city.Country = encompasses.Country 
        WHERE encompasses.Continent = 'America' 
        ORDER BY Population
        DESC LIMIT 3;

    --13. Wie viel Prozent der Menschen leben im Kontinent Europa?
        SELECT ROUND(SUM(country.Population/(SELECT SUM(country.Population) FROM country)*100),2) AS PopulationPercent 
        FROM country 
        JOIN encompasses ON country.Code = encompasses.Country 
        WHERE encompasses.Continent = 'Europe';

    --14. Das Unabhängigkeitsdatum von Länder die eine Wüste haben und die ethnische Gruppe African
        SELECT DISTINCT politics.Independence, geo_desert.Country
        FROM politics, geo_desert
        JOIN ethnicgroup ON geo_desert.Country = ethnicgroup.Country 
        WHERE ethnicgroup.Country = politics.Country
        AND ethnicgroup.Name = 'African'


    --15. Welche Länder haben genau 3 Städte? 
        SELECT country.Name AS CountryName, COUNT(*) AS AmountCities
        FROM city
        JOIN country ON city.Country = country.Code
        GROUP BY country.Name HAVING AmountCities = 3;

    --16. Was ist der größte Berg pro Kontinent? Wie hoch sind diese?
    -- Schreibt alle Berge nach der Größe aus
        SELECT DISTINCT encompasses.Continent, geo_mountain.Mountain, mountain.Height AS MaxHeight
        FROM mountain
        JOIN geo_mountain ON mountain.Name = geo_mountain.Mountain
        JOIN encompasses ON geo_mountain.Country = encompasses.Country
        WHERE mountain.Height = (SELECT MAX(mountain.Height))
        ORDER BY MaxHeight
        DESC  

        WITH maxMountains as (SELECT DISTINCT encompasses.continent, geo_mountain.Mountain, mountain.height, RANK() over (
        partition by encompasses.continent order by mountain.Height desc) AS mountainRank 
        FROM mountain
        JOIN geo_mountain ON mountain.Name = geo_mountain.Mountain
        JOIN encompasses On geo_mountain.Country = encompasses.Country)
        SELECT * from maxMountains 
        WHERE mountainRank = 1;

    -- 17. Welche Organisationen haben deren Hauptsitz in Österreich? Wie viele Mitglieder haben diese Organisationen?
        SELECT organization.Name, COUNT(ismember.Organization) AS Members
        FROM organization, ismember
        WHERE ismember.Organization = organization.Abbreviation
        AND organization.Country = 'A'
        GROUP BY organization.Name
        ORDER BY organization.Name;

    -- 18. Alle Länder mit mindestens einem See mit mindestens 100 Meter Tiefe und mindestens einem Berg mit mindestens 1500 Höhenmeter
        SELECT DISTINCT c.Name
        FROM Lake, geo_lake gl, mountain, geo_mountain gm, country c
        WHERE gl.Country = c.code
        AND  gl. Lake = Lake.Name
        AND Lake.Depth > 100
        AND gm.Country = c.Code
        AND gm.Mountain = Mountain.Name
        AND Mountain.Height > 1500

    -- 19. Alle Länder, nur die Namen, und wenn sie haben, das Meer dazu
        SELECT DISTINCT country.Name, geo_sea.Sea
        FROM country
        LEFT JOIN geo_sea ON country.Code = geo_sea.Country

    -- 20. Erstelle eine neue “Organization” mit dem Namen “DCV-Grundkurs”. 
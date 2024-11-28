SELECT * from country WHERE name = 'Austria';

SELECT name FROM country WHERE name LIKE 'A%';

SELECT * FROM continent WHERE name = 'Europe';

SELECT * FROM geo_river WHERE country = 'A';

SELECT SUM(Population) AS total_Population, Continent FROM 	encompasses, country WHERE Continent = 'Europe' AND country.Code = 	encompasses.Country;

SELECT geo_river.River FROM encompasses, geo_river WHERE encompasses.Country = geo_river.Country AND encompasses.Continent = 'Europe';

SELECT DISTINCTgeo_river.River, river.Length 
FROM encompasses, geo_river, river 
WHERE geo_river.River = river.Name 
AND encompasses.Country = geo_river.Country 
AND encompasses.Continent = 'Europe' 
ORDER BY river.Length;

SELECT DISTINCT Country.code, province.population, province.name
FROM Country, Province
WHERE Country.code = province.country and country.code LIKE 'A%'
ORDER BY country.code ASC;

SELECT mountain.Name, mountain.Height 
FROM mountain, geo_mountain 
WHERE geo_mountain.Mountain = mountain.Name 
AND geo_mountain.Country = 'A' 
ORDER BY mountain.Height DESC LIMIT 1;

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
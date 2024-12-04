-- Erster Versuch mit WHERE.
use mondial;
SELECT country.Code, country.Name, country.Population
FROM country
WHERE country.Code = 'A';

SELECT encompasses.Continent, country.Code, ismember.Organization
FROM country, ismember, organization, encompasses
WHERE (country.Code = ismember.Country AND ismember.Organization = organization.Abbreviation AND country.Code = 'A' AND ismember.Organization = 'NATO') 
AND (country.Code = encompasses.Country AND country.Code = 'A' AND encompasses.Continent = 'Europe')
OR (country.Code = ismember.Country AND ismember.Organization = organization.Abbreviation AND country.Code = 'A' AND ismember.Organization = 'NATO')
OR (country.Code = encompasses.Country AND country.Code = 'A' AND encompasses.Continent = 'Europe')
ORDER BY country.Code;

-- Loesung ueber JOINS.
SELECT * FROM 
-- Beziehung country und ismember
country INNER JOIN ismember ON country.code = ismember.country 
-- Beziehung ismember und organization
INNER JOIN organization ON ismember.Organization = organization.Abbreviation
-- Beziehung country und encompasses
INNER JOIN encompasses ON country.code = encompasses.Country
-- Zusätzliche Filter
WHERE country.Code = 'B' AND ismember.Organization = 'NATO' AND encompasses.Continent = 'Europe'
OR country.Code = 'B' AND ismember.Organization = 'NATO'
OR country.Code = 'B' AND encompasses.Continent = 'Europe'
ORDER BY country.Code;
SELECT country.Name, country.Code, province.Name AS Provincename, country.Population
FROM country
INNER JOIN province ON country.Code = province.Country
WHERE country.Name LIKE 'A%'
ORDER BY country.Population ASC;
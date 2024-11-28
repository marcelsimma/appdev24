USE mondial;

SELECT ROUND(SUM(country.Population/(SELECT SUM(country.Population) FROM country)*100), 2) AS PopulationPercent
FROM country
JOIN encompasses ON country.Code = encompasses.Country
WHERE encompasses.Continent = 'Europe';
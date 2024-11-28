USE mondial;

SELECT SUM(Population) AS total_Population 
FROM mondial.country, mondial.encompasses 
WHERE encompasses.Continent = 'Europe' AND country.Code = encompasses.Country;
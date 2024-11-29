SELECT encompasses.Country, encompasses.Continent, city.Name, city.Population
FROM encompasses
JOIN country ON encompasses.Country = country.Code
JOIN city ON country.Code = city.Country
WHERE encompasses.Continent = 'America'
ORDER BY city.Population DESC
LIMIT 3;
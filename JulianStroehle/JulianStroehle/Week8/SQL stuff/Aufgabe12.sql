USE mondial;

SELECT *
FROM city
JOIN encompasses ON city.Country = encompasses.Country
WHERE encompasses.Continent = 'America'
ORDER BY Population DESC
LIMIT 3;
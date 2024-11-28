USE mondial;

SELECT country.Name, city.Name, city.Population
FROM country
LEFT JOIN city ON country.Code = city.Country
WHERE country.Name LIKE 'A%'
ORDER BY city.Population;
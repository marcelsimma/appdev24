Use Mondial;
 
SELECT country.name, province.name, province.population
FROM country, province
WHERE country.code = Province.country
AND country.name like 'A%'
Order by country.name, province.population;
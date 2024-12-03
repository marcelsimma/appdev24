SELECT count(city.name) AS anzahl, country.Name from country, city WHERE
country.Code = city.Country
GROUP BY country.name
HAVING anzahl = 3
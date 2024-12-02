SELECT count(city.name) AS anzahl, country.Name from country, city WHERE country.Code = city.Country
GROUP BY country.Name
HAVING anzahl = 3
;


WITH sub as (SELECT count(*) AS anzahl, country.Name from country, city WHERE
country.Code = city.Country
GROUP BY country.Code)
SELECT Name FROM sub WHERE anzahl = 3
;
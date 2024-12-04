-- 7.1) Alle Länder die mit einem A anfangen und deren Bundesländer mit Einwohnerzahl, sortiert nach Einwohnerzahl
USE Mondial;
SELECT country.name,
       city.name,
       city.population
FROM   country
       LEFT JOIN city
              ON country.code = city.country
WHERE  country.name LIKE 'A%'
ORDER  BY city.population;  
-- 7.2) Alle Länder die mit einem A anfangen und deren Bundesländer mit Einwohnerzahl, sortiert nach Einwohnerzahl 
USE Mondial;
SELECT country.name,
       city.province,
       city.population
FROM   country
       LEFT JOIN city
              ON country.code = city.country
WHERE  country.name LIKE 'A%'
ORDER  BY city.population;  
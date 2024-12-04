-- 15) Welche Länder haben genau 3 Städte? Welche Länder sind dies?
USE Mondial;
SELECT country.name AS CountryName,
       Count(*)     AS AnzStaedte
FROM   mondial.city
       JOIN mondial.country
         ON city.country = country.code
GROUP  BY country.name
HAVING Count(*) = 3;  
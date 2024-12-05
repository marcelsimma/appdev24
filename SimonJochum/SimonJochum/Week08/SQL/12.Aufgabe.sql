-- 12) Welches sind die 3 größten Städte von Amerika (Kontinent)?
USE Mondial;
SELECT *
FROM   city
       JOIN encompasses
         ON city.country = encompasses.country
WHERE  encompasses.continent = 'America'
ORDER  BY population DESC
LIMIT  3;  
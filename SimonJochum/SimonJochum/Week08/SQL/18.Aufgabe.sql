-- 18) Alle Länder mit mindestens einem See mit mindestens 100 Meter Tiefe und mindestens einem Berg mit mindestens 1500 Höhenmeter
USE Mondial;
SELECT DISTINCT country.name
FROM   country,
       geo_lake,
       lake,
       geo_mountain,
       mountain
WHERE  geo_lake.country = country.code
       AND geo_lake.lake = lake.name
       AND lake.depth > 100
       AND geo_mountain.country = country.code
       AND geo_mountain.mountain = mountain.name
       AND mountain.height > 1500
ORDER  BY country.name;  
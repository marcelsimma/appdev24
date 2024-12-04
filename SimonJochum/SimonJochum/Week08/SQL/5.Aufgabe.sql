-- 5) Welche Flüsse fließen durch Europa (nur den Flussnamen)?
USE Mondial;
SELECT river
FROM   geo_river,
       encompasses
WHERE  encompasses.continent = 'Europe'
       AND geo_river.country = encompasses.country;  
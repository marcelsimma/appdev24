-- 6) Alle Flüsse die durch Europa fließen (nur Flüsse und deren Länge), sortiert nach Länge
USE Mondial;
SELECT DISTINCT ( geo_river.river ),
                river.length
FROM   geo_river,
       encompasses,
       river
WHERE  encompasses.continent = 'Europe'
       AND geo_river.country = encompasses.country
       AND river.name = geo_river.river
ORDER  BY river.length;  
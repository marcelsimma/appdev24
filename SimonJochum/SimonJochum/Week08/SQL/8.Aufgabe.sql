-- 8) Was ist der größte Berg von Österreich? Wie hoch ist er?
USE Mondial;
SELECT name,
       Max(mountain.height) AS HighestMountain
FROM   mountain
       JOIN geo_mountain
         ON mountain.name = geo_mountain.mountain
WHERE  geo_mountain.country = 'A'
GROUP  BY name
LIMIT  1;  
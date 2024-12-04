-- 10)Alle 3000er, welche in einem Land sind, welches zu mindestens 60% römisch Katholisch ist
USE Mondial;
SELECT DISTINCT mountain.name,
                mountain.height
FROM   mountain,
       religion,
       geo_mountain
WHERE  mountain.name = geo_mountain.mountain
       AND geo_mountain.country = religion.country
       AND mountain.height > 3000
       AND religion.name = 'Roman Catholic'
       AND religion.percentage >= 60
ORDER  BY mountain.height;  
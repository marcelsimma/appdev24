-- 16) Was ist der größte Berg pro Kontinent? Wie hoch sind diese?
USE Mondial;
SELECT DISTINCT encompasses.continent,
                geo_mountain.mountain,
                mountain.height AS MaxHeight
FROM   mountain
       JOIN geo_mountain
         ON mountain.name = geo_mountain.mountain
       JOIN encompasses
         ON geo_mountain.country = encompasses.country
WHERE  mountain.height = (SELECT Max(m.height)
                          FROM   mountain m
                                 JOIN geo_mountain gm
                                   ON m.name = gm.mountain
                                 JOIN encompasses e
                                   ON gm.country = e.country
                          WHERE  e.continent = encompasses.continent)
ORDER  BY maxheight DESC;  
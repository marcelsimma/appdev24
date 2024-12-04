-- 1) Wie viele Einwohner hat Österreich?
USE Mondial;
SELECT name,
       population
FROM   country
WHERE  name = 'Austria';  

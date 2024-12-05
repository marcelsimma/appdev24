-- 4) Wie viele Einwohner hat der Kontinent Europa?
USE Mondial;
SELECT Sum(population) AS total_Population
FROM   mondial.country,
       mondial.encompasses
WHERE  encompasses.continent = 'Europe'
       AND country.code = encompasses.country;  
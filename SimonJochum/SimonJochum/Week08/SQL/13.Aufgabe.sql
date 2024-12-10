-- 13) Wie viel Prozent der Menschen leben im Kontinent Europa?
USE Mondial;
SELECT Round(Sum(country.population / (SELECT Sum(country.population)
                                       FROM   country) * 100), 2) AS
       PopulationPercent
FROM   country
       JOIN encompasses
         ON country.code = encompasses.country
WHERE  encompasses.continent = 'Europe';  
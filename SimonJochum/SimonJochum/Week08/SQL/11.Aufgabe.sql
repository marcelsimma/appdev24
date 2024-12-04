-- 11) Einwohnerzahl pro Religion
USE Mondial;
SELECT religion.name,
       Sum(country.population) AS Population
FROM   religion
       JOIN country
         ON religion.country = country.code
GROUP  BY religion.name;
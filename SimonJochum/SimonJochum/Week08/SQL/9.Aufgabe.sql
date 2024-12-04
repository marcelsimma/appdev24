-- 9) Alle Inseln im Pazifik mit >50% islamischem Bekenntnis
USE Mondial;
SELECT islandin.island,
       islandin.sea,
       religion.name AS Religion,
       religion.percentage
FROM   islandin,
       religion
       JOIN geo_island
         ON religion.country = geo_island.country
WHERE  islandin.sea = 'Pacific Ocean'
       AND islandin.island = geo_island.island
       AND religion.name = 'Muslim'
       AND religion.percentage > 50;  
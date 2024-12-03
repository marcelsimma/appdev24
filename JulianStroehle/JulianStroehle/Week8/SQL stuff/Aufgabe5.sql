USE mondial;

SELECT River
FROM geo_river, encompasses
WHERE encompasses.Continent = 'Europe' AND geo_river.Country = encompasses.Country;
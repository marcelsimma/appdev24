USE mondial;

SELECT DISTINCT (geo_river.River), river.Length
FROM geo_river, encompasses, river
WHERE encompasses.Continent = 'Europe' AND geo_river.Country = encompasses.Country AND river.Name = geo_river.River
ORDER BY river.Length;
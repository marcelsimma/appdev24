USE mondial;

SELECT river.Name 
FROM continent, encompasses, country, province, geo_river, river
WHERE continent.Name = encompasses.Continent
AND encompasses.Country = country.Code
AND country.Code = province.Country
AND province.Name = geo_river.Province
AND river.Name = geo_river.River
AND continent.Name LIKE 'Europe'
GROUP BY river.Name
ORDER by river.Name;
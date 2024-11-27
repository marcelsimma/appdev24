USE mondial;

SELECT river.Name FROM continent
INNER JOIN encompasses ON continent.Name = encompasses.Continent
INNER JOIN country ON country.Code = encompasses.Country
INNER JOIN province ON province.Country = country.Code
INNER JOIN geo_river ON geo_river.Province = province.Name
INNER JOIN river ON river.Name = geo_river.River
WHERE continent.Name LIKE 'Europe'
GROUP BY river.Name
ORDER BY river.Name;
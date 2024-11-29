SELECT DISTINCT river.River, river.Length
FROM river
INNER JOIN geo_river ON river.River = geo_river.River
INNER JOIN encompasses ON geo_river.Country = encompasses.Country
WHERE encompasses.Continent LIKE 'Europe'
ORDER BY Length ASC;